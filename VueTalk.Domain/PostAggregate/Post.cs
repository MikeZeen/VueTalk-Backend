using VueTalk.Domain.Author.ValueObjects;
using VueTalk.Domain.Comment.ValueObjects;
using VueTalk.Domain.Common.Models;
using VueTalk.Domain.Post.ValueObjects;
using VueTalk.Domain.Rating.ValueObjects;

namespace VueTalk.Domain.Post;

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
