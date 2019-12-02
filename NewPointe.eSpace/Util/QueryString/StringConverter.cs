
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NewPointe.Util.QueryString
{
    public class StringConverter {

        public static string ToStringDynamic(object value) => ToString((dynamic) value);

        public static string ToString(string value) => value;
        public static string ToString(object value) => value != null ? value.ToString() : null;
        public static string ToString(DateTime? value) => value.HasValue ? value.Value.ToString("u") : null;
        public static string ToString(object[] values) => string.Join(",", Array.ConvertAll(values, ToStringDynamic));

    }
}