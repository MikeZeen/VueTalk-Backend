using ErrorOr;
using MediatR;
using VueTalk.Application.Common.Interfaces.Persistence;
using VueTalk.Domain.CategoryAggregate;

namespace VueTalk.Application.Categories.Commands.CreateCategory;
public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, ErrorOr<Category>>
{
    private readonly ICategoryRepository _categoryRepository;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<Category>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var category = Category.Create(
            request.Name,
            request.Description);

        _categoryRepository.Add(category);

        return category;
    }
}

