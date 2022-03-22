using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;

namespace adduo.elephant.utilities.entries
{
    public class Entry
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public StatusCode Status { get; protected set; }

        [JsonPropertyName("error")]
        public ErrorCode Error { get; protected set; }

        public bool Edit { get; set; }

        public bool Prop { get { return true; } }

        public Entry()
        {
            Reset();
        }

        public void Reset()
        {
            Status = StatusCode.NONE;
            Error = ErrorCode.NONE;
        }




        #region Status

        public bool IsValidStatus()
        {
            return Status == StatusCode.VALID;
        }

        public bool IsInvalidStatusCode()
        {
            return Status == StatusCode.INVALID;
        }

        public void SetStatusValidCode()
        {
            Status = StatusCode.VALID;
        }

        public void SetStatusInvalidCode()
        {
            Status = StatusCode.INVALID;
        }

        public void SetStatusNoneCode()
        {
            Status = StatusCode.NONE;
        }

        public bool IsNotInvalidStatus()
        {
            return Status != StatusCode.INVALID;
        }

        public bool IsInvalidOrEmptyStatusCode()
        {
            return Status == StatusCode.INVALID || Status == StatusCode.NONE;
        }

        public bool IsNoneStatusCode()
        {
            return Status == StatusCode.NONE;
        }

        #endregion

        #region Error


        public bool IsNoneErrorCode()
        {
            return Error == ErrorCode.NONE;
        }

        public bool IsAlreadyErrorCode()
        {
            return Error == ErrorCode.ALREADY;
        }

        public bool IsEmptyErrorCode()
        {
            return Error == ErrorCode.EMPTY;
        }

        public bool IsInvalidErrorCode()
        {
            return Error == ErrorCode.INVALID;
        }

        public bool IsInactiveErrorCode()
        {
            return Error == ErrorCode.INACTIVE;
        }

        public bool IsErrorErrorCode()
        {
            return Error == ErrorCode.ERROR;
        }

        public bool IsNotFoundErrorCode()
        {
            return Error == ErrorCode.NOTFOUND;
        }

        public bool IsDifferentErrorCode()
        {
            return Error == ErrorCode.DIFFERENT;
        }

        public void SetErrorCode(ErrorCode errorCode, StatusCode statusCodeWhenNoneError = StatusCode.NONE)
        {
            Status = errorCode == ErrorCode.NONE ? statusCodeWhenNoneError : StatusCode.INVALID;
            Error = errorCode;
        }

        public void SetNoneErrorCode()
        {
            SetErrorCode(ErrorCode.NONE);
        }

        public void SetAlreadyErrorCode()
        {
            SetErrorCode(ErrorCode.ALREADY);
        }

        public void SetEmptyErrorCode()
        {
            SetErrorCode(ErrorCode.EMPTY);
        }

        public void SetInvalidErrorCode()
        {
            SetErrorCode(ErrorCode.INVALID);
        }

        public void SetInactiveErrorCode()
        {
            SetErrorCode(ErrorCode.INACTIVE);
        }

        public void SetErrorErrorCode()
        {
            SetErrorCode(ErrorCode.ERROR);
        }

        public void SetNotFoundErrorCode()
        {
            SetErrorCode(ErrorCode.NOTFOUND);
        }

        public void SetDifferentErrorCode()
        {
            SetErrorCode(ErrorCode.DIFFERENT);
        }

        #endregion


        public bool IsMaxLengthCode()
        {
            return Error == ErrorCode.MAXLENGTH;
        }

        public virtual bool Validate() { return true; }

    }

    public class Entry<T> : Entry, IEntry<T>
    {
        [JsonPropertyName("value")]
        public T Value { get; set; }

        [JsonPropertyName("defaultValue")]
        public T DefaultValue { get; set; }

        private List<IEntryValidation<T>> Validations { get; set; }

        public Entry()
        {
            Validations = new List<IEntryValidation<T>>();
        }

        public void ClearValidation()
        {
            Validations = new List<IEntryValidation<T>>();
        }

        public void AddValidation(IEntryValidation<T> validation)
        {
            validation.Set(this);

            Validations.Add(validation);
        }

        public virtual bool HasValue()
        {
            return !Value.Equals(default(T));
        }

        public override bool Validate()
        {
            foreach (var validation in Validations)
            {
                validation.Validate();
            }

            return true;
        }
    }


}
