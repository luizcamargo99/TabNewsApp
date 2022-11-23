using TabNewsApp.Constants;

namespace TabNewsApp.Extensions
{
    internal static class DateExtension
    {
        public static DateTime RealNow()
        {
            var result = new HttpClient().GetAsync("https://www.google.com", HttpCompletionOption.ResponseHeadersRead).Result;
            var realDateTime = result.Headers.Date;
            TimeZoneInfo currentTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneConstant.Current);
            return TimeZoneInfo.ConvertTimeFromUtc(realDateTime.Value.DateTime, currentTimeZone);
        }
    }
}
