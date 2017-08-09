using System;
using System.ComponentModel;
using System.Reflection;

namespace BuildMaster.Net.Common
{
    public static class EnumExtensions
    {
        private static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetTypeInfo().GetDeclaredField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes?.Length > 0)
            {
                return attributes[0].Description;
            }

            return value.ToString();
        }

        public static string GetEnumDescription<TEnum>(int value)
        {
            return GetEnumDescription((Enum)(object)(TEnum)(object)value);
        }

        public static string GetEnumDescription<TEnum>(TEnum value)
        {
            return GetEnumDescription((Enum)(object)value);
        }
    }
}
