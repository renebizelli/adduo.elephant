namespace adduo.elephant.utilities.entries.entry_validators
{
    public class BaseEntryValidator<T>
    {
        public IEntry<T> entry { get; set; }

        public void Set(IEntry<T> entry)
        {
            this.entry = entry;
        }

        protected bool CanValidate()
        {
            return entry.IsNotInvalidStatus();
        }

        protected void SetAlreadyStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.ALREADY, entry);
        }

        protected void SetEmptyStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.EMPTY, entry);
        }

        protected void SetInvalidStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.INVALID, entry);
        }

        protected void SetInactiveStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.INACTIVE, entry);
        }

        protected void SetErrorStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.ERROR, entry);
        }

        protected void SetNotFoundStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.NOTFOUND, entry);
        }

        protected void SetDifferentStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.DIFFERENT, entry);
        }

        protected void SetDifferentStatus(bool valid, Entry<T> entry)
        {
            SetStatus(valid, ErrorCode.DIFFERENT, entry);
        }

        protected void SetMaxlengthStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.MAXLENGTH, entry);
        }

        protected void SetNoneStatus(bool valid)
        {
            SetStatus(valid, ErrorCode.NONE, entry);
        }

        protected void SetNoneStatus(bool valid, IEntry<T> entry)
        {
            SetStatus(valid, ErrorCode.NONE, entry);
        }

        private void SetStatus(bool valid, ErrorCode error, IEntry<T> targetProperty)
        {
            if (valid)
            {
                targetProperty.SetStatusValidCode();
            }
            else
            {
                targetProperty.SetErrorCode(error, StatusCode.INVALID);
            }
        }
    }

}
