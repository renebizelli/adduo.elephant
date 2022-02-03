﻿using System.Collections.Generic;
using System.Linq;

namespace adduo.elephant.utilities.extensionmethods
{
    public static class Listextensionmethods
    {
        public static bool Empty(this IList<int> _list)
        {
            return !_list.Any();
        }

        public static bool Empty(this IList<string> _list)
        {
            return !_list.Any();
        }

        public static string ToStringList(this IList<int> _list)
        {
            var result = string.Empty;

            if(_list != null && _list.Any())
            {
                result = string.Join(",", _list);
            }

            return result;
        }
    }
}
