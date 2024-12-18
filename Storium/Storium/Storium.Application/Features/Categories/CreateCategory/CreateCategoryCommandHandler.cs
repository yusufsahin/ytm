﻿
using MediatR;
using Storium.Domain.Abstractions;
using Storium.Domain.Categories;

namespace Storium.Application.Features.Categories.CreateCategory
{
    internal sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepository.CreateAsync(request.Name, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
