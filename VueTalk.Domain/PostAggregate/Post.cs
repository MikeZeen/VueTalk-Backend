using VueTalk.Domain.AuthorAggregate.ValueObjects;
using VueTalk.Domain.CommentAggregate.ValueObjects;
using VueTalk.Domain.Common.Models;
using VueTalk.Domain.PostAggregate.ValueObjects;
using VueTalk.Domain.RatingAggregate.ValueObjects;

namespace VueTalk.Domain.PostAggregate;

public sealed class Post : AggregateRoot<PostId>
{
    private readonly List<CommentId> _commentIds = new();
    private readonly List<RatingId> _ratingIds = new();
    public string Name { get; }
    public string Text { get; }
    public float AverageRating { get; }
    public AuthorId AuthorId { get; }
    public IReadOnlyList<CommentId> CommentIds => _commentIds;
    public IReadOnlyList<RatingId> RatingIds => _ratingIds;
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Post(
        PostId postId,
        string name,
        string text,
        AuthorId authorId,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(postId)
    {
        Name = name;
        Text = text;
        AuthorId = authorId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Post Create(
        string name,
        string text,
        AuthorId authorId)
    {
        return new(
            PostId.CreateUnique(),
            name,
            text,
            authorId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }

    
}
