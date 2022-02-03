﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace adduo.elephant.utilities.extensionmethods
{
    public static class EnumExtensionMethod
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }

}
