using VueTalk.Domain.CategoryAggregate.ValueObjects;
using VueTalk.Domain.Common.Models;


namespace VueTalk.Domain.CategoryAggregate; 

public sealed class Category : AggregateRoot<CategoryId>
{
    public string Name { get; }
    public string Description { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Category(
        CategoryId categoryId,
        string name,
        string description,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(categoryId)
    {
        Name = name;
        Description = description;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Category Create(
        string name,
        string description)
    {
        return new(
            CategoryId.CreateUnique(),
            name,
            description,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }


}
