﻿using Business.Requests.Brands;
using Business.Requests.Models;
using Business.Responses.Brands;
using Business.Responses.Models;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IModelService
{
    Task<CreateModelResponse> AddAsync(CreateModelRequest request);
    Task<List<GetAllModelResponse>> GetAllAsync();
}