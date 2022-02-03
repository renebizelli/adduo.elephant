using System.Net;

namespace adduo.elephant.utilities.entries
{
    public interface IEntry<T>
    {
        T Value { get; set; }

        void SetStatusValidCode();
        void SetStatusInvalidCode();
        void SetStatusNoneCode();

        bool IsAlreadyErrorCode();
        bool IsDifferentErrorCode();
        bool IsEmptyErrorCode();
        bool IsNoneStatusCode();
        bool IsErrorErrorCode();
        bool IsInactiveErrorCode();
        bool IsInvalidErrorCode();
        bool IsInvalidOrEmptyStatusCode();
        bool IsInvalidStatusCode();
        bool IsMaxLengthCode();
        bool IsNoneErrorCode();
        bool IsNotFoundErrorCode();
        bool IsNotInvalidStatus();
        bool IsValidStatus();
        void Reset();
        void SetAlreadyErrorCode();
        void SetErrorCode(ErrorCode errorCode, StatusCode statusCodeWhenNoneError = StatusCode.NONE);
        void SetDifferentErrorCode();
        void SetEmptyErrorCode();
        void SetErrorErrorCode();
        void SetInactiveErrorCode();
        void SetInvalidErrorCode();
        void SetNoneErrorCode();
        void SetNotFoundErrorCode();
        bool Validate();

    }
}
