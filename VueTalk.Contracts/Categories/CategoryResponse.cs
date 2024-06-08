namespace VueTalk.Contracts.Categories;

public record CategoryResponse(
    string Id,
    string Name,
    string Description,
    DateTime CreatedDateTime,
    DateTime UpdatedDateTime);
