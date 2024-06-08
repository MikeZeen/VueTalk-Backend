
using VueTalk.Domain.CategoryAggregate;

namespace VueTalk.Application.Common.Interfaces.Persistence;

public interface ICategoryRepository
{
    void Add(Category category);
}