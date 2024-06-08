using VueTalk.Application.Common.Services;

namespace VueTalk.Application.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}   