

using Storium.Domain.Categories;

namespace Storium.Application.Features.Categories.GetAllCategory
{
    internal sealed class GetAllCategoryQueryHandler
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }
        public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAllAsync(cancellationToken);
        }
    }
}
