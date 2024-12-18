

using MediatR;

namespace Storium.Application.Features.Categories.CreateCategory
{
    public sealed record CreateCategoryCommand(string Name):IRequest;
}
