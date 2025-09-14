using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public static class EnumHelper
    {
        public static List<KeyValuePair<string, int>> GetEnumDescriptionAndValue<T>()
        {
            var list = new List<KeyValuePair<string, int>>();
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                string description = value.ToString();
                var fieldInfo = value.GetType().GetField(description);
                var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));

                if (attribute != null)
                {
                    description = attribute.Description;
                }

                list.Add(new KeyValuePair<string, int>(description, (int)value));
            }
            return list;
        }


    }
}
