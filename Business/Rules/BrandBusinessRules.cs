using Core.CrossCuttingConcerns.Rules;
using Core.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class BrandBusinessRules : BaseBusinessRules
    {
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task CheckIfBrandNameNotExists(string brandName)
        {
            var isExists = await _brandRepository.Get(brand => brand.Name == brandName);
            if (isExists is not null)
            {
                throw new BusinessException("Brand name already exists");
            }
        }
    }
}
