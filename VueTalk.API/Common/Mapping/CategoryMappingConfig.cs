using Mapster;
using VueTalk.Application.Categories.Commands.CreateCategory;
using VueTalk.Contracts.Categories;
using VueTalk.Domain.CategoryAggregate;

namespace VueTalk.API.Common.Mapping;

public class CategoryMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateCategoryRequest, CreateCategoryCommand>();
        config.NewConfig<Category, CategoryResponse>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}
