using ErrorOr;
using MediatR;
using VueTalk.Domain.CategoryAggregate;

namespace VueTalk.Application.Categories.Commands.CreateCategory;

public record CreateCategoryCommand(
    string Name,
    string Description
    ) : IRequest<ErrorOr<Category>>;
