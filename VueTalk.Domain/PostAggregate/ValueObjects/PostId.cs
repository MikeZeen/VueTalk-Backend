﻿using VueTalk.Domain.Common.Models;

namespace VueTalk.Domain.Post.ValueObjects;

public sealed class PostId : ValueObject
{
    public Guid Value { get; }

    private PostId(Guid value)
    {
        Value = value;
    }

    public static PostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
