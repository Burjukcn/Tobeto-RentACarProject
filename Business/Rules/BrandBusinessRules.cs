using Core.CrossCuttingConcerns.Rules;
using Core.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class BrandBusinessRules : BaseBusinessRules
    {
        private readonly IBrandRepository _repository;

        public BrandBusinessRules(IBrandRepository repository)
        {
            _repository = repository;
        }

        public async Task CheckIfBrandNameNotExists(string brandName)
        {
            var isExists = await _repository.Get(brand => brand.Name == brandName);
            if (isExists is not null) throw new BusinessException("Brand name already exists");
        }
    }
}
