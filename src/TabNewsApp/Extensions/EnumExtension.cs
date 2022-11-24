using System.ComponentModel;
using TabNewsApp.Attributes;

namespace TabNewsApp.Extensions
{
    internal static class EnumExtension
    {
        public static string ToDescription<TEnum>(this TEnum enumValue) where TEnum : struct
        {
            return typeof(TEnum).GetMember(enumValue.ToString())
                .SelectMany(member => member.GetCustomAttributes(typeof(DescriptionAttribute), true).Cast<DescriptionAttribute>()).FirstOrDefault().Description;
        }

        public static string ToIconDescription<TEnum>(this TEnum enumValue) where TEnum : struct
        {
            return typeof(TEnum).GetMember(enumValue.ToString())
                .SelectMany(member => member.GetCustomAttributes(typeof(IconAttribute), true).Cast<IconAttribute>()).FirstOrDefault().IconValue;
        }
    }
}
