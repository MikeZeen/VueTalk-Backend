using VueTalk.Domain.Category.ValueObjects;
using VueTalk.Domain.Common.Models;


namespace VueTalk.Domain.Category; 

public sealed class Post : AggregateRoot<CategoryId>
{
    public string Name { get; }
    public string Description { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Post(
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

    public static Post Create(
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
