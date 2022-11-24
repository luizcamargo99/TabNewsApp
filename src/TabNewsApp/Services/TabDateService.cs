using TabNewsApp.Constants;
using TabNewsApp.Interfaces;

namespace TabNewsApp.Services;
internal class TabDateService : ITabDateService
{
    public DateTime RealNow
    {
        get { return GetRealNow(); }
    }

    private DateTime GetRealNow()
    {
        var result = new HttpClient().GetAsync("https://www.google.com", HttpCompletionOption.ResponseHeadersRead).Result;
        var realDateTime = result.Headers.Date;
        TimeZoneInfo currentTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneConstant.Current);
        return TimeZoneInfo.ConvertTimeFromUtc(realDateTime.Value.DateTime, currentTimeZone);
    }
}
