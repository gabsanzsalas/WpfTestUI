using System;

namespace WpfTestUI
{
    public interface IUCTestableStatus<TStatus> where TStatus : Enum
    {
        void SetStatus(TStatus status);
    }
}