﻿using VueTalk.Domain.Common.Models;

namespace VueTalk.Domain.CategoryAggregate.ValueObjects;

public sealed class CategoryId : ValueObject
{
    public Guid Value { get; }

    private CategoryId(Guid value)
    {
        Value = value;
    }

    public static CategoryId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
