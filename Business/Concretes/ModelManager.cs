﻿using AutoMapper;
using Business.Abstracts;
using Business.Requests.Models;
using Business.Responses.Models;
using Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class ModelManager : IModelService
{
    private readonly IModelRepository _modelRepository;
    private readonly IMapper _mapper;
    private readonly ModelBusinessRules _rules;

    public ModelManager(IModelRepository modelRepository, IMapper mapper, ModelBusinessRules rules)
    {
        _modelRepository = modelRepository;
        _mapper = mapper;
        _rules = rules;
    }

    public async Task<CreateModelResponse> AddAsync(CreateModelRequest request)
    {
        await _rules.CheckIfBrandExists(request.BrandId);
        Model model = _mapper.Map<Model>(request);
        await _modelRepository.Add(model);

        CreateModelResponse response = _mapper.Map<CreateModelResponse>(model);
        return response;
    }

    public async Task<List<GetAllModelResponse>> GetAllAsync()
    {
        List<Model> models = await _modelRepository.GetAll(include: x => x.Include(x => x.Brand));
        List<GetAllModelResponse> responses = _mapper.Map<List<GetAllModelResponse>>(models);
        return responses;
    }
}