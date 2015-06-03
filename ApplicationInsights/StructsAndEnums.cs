using System;
using System.Runtime.InteropServices;

using ObjCRuntime;

namespace ApplicationInsights
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void MSAICrashManagerPostCrashSignalCallback(IntPtr context);

    public struct MSAICrashManagerCallbacks
    {
        IntPtr Context;

        MSAICrashManagerPostCrashSignalCallback HandleSignal;
    }

    [Native]
    public enum MSAICrashErrorReason : long
    {
        ErrorUnknown,
        APIAppVersionRejected,
        APIReceivedEmptyResponse,
        APIErrorWithStatusCode
    }

    [Native]
    public enum MSAIErrorReason : long
    {
        ErrorUnknown
    }
}

