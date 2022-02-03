using System;

namespace adduo.elephant.utilities.extensionmethods
{
    public static class Guidextensionmethods
    {
        public static bool IsEmpty(this Guid _guid)
        {
            return _guid.Equals(Guid.Empty);
        }

        public static bool NotIsEmpty(this Guid _guid)
        {
            return !_guid.IsEmpty();
        }

        [Obsolete("Substituir por ToStringEmpty()", true)]
        public static string ToStringNullIfEmpty(this Guid _guid)
        {
            return _guid.IsEmpty() ? string.Empty : _guid.ToString();
        }

        [Obsolete("Substituir por ToStringEmpty()", true)]
        public static string ToStringEmptyIfEmpty(this Guid _guid)
        {
            return _guid.IsEmpty() ? string.Empty : _guid.ToString();
        }

        public static string ToStringEmpty(this Guid _guid)
        {
            return _guid.IsEmpty() ? string.Empty : _guid.ToString();
        }

    }
}
