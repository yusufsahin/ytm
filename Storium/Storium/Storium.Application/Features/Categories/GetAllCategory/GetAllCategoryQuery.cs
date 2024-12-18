using MediatR;
using Storium.Domain.Categories;

namespace Storium.Application.Features.Categories.GetAllCategory
{
    public sealed record GetAllCategoryQuery() : IRequest<List<Category>>;
}
