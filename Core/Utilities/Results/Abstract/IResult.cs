using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        string Message { get; }
        bool Success { get; }
    }
}
