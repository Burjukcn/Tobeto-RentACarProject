using Core.DataAccess.EntityFramwork;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;


namespace DataAccess.Concretes.Repositories
{

    public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}