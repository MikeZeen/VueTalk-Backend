﻿using VueTalk.Domain.Common.Models;

namespace VueTalk.Domain.Comment.ValueObjects;

public sealed class CommentId : ValueObject
{
    public Guid Value { get; }

    private CommentId(Guid value)
    {
        Value = value;
    }

    public static CommentId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
