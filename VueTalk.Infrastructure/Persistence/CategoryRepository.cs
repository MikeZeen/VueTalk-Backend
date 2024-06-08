
using VueTalk.Application.Common.Interfaces.Persistence;
using VueTalk.Domain.CategoryAggregate;

namespace VueTalk.Infrastructure.Persistence;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> _categories = new();

    public void Add(Category category)
    {
        _categories.Add(category);
    }
}
