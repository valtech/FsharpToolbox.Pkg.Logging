module FsharpToolbox.Pkg.Logging

open System
open Serilog
open System.Runtime.CompilerServices
open System.Runtime.InteropServices
open Serilog.Context

let inline pushPropertiesLogAndReset (logFunction: Lazy<unit>) (memberName: string) (path: string) (line: int) =
    use mem = LogContext.PushProperty("membername", memberName + "(..)")
    use path = LogContext.PushProperty("path", path)
    use line = LogContext.PushProperty("line", line)
    logFunction.Force()

let inline pushPropertiesLogAndResetWithExn (logFunction: Lazy<unit>) (memberName: string) (path: string) (line: int) (ex: exn) =
    use mem = LogContext.PushProperty("membername", memberName + "(..)")
    use path = LogContext.PushProperty("path", path)
    use line = LogContext.PushProperty("line", line)
    use ex = LogContext.PushProperty("Exception", ex)
    logFunction.Force()

type Logger() =
    // ----- DEBUG -----
    // ----- 0 args -----
    member inline this.Debug((message: string),
                  [<Optional>] _ignore: unit,
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message)) memberName path line

    // ----- 1 arg -----
    member inline this.Debug((message: string, a),
                      [<Optional>] _ignore: unit,
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a :> obj)) memberName path line

    // ----- 2 args -----
    member inline this.Debug((message: string, a, b),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b)) memberName path line

    // ----- 3 args -----
    member inline this.Debug((message: string, a, b, c),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b, c)) memberName path line

    // ----- 4 args -----
    member inline this.Debug((message: string, a, b, c, d),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b, c, d)) memberName path line

    // ----- 5 args -----
    member inline this.Debug((message: string, a, b, c, d, e),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b, c, d, e)) memberName path line

    // ----- 6 args -----
    member inline this.Debug((message: string, a, b, c, d, e, f),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b, c, d, e, f)) memberName path line

    // ----- 7 args -----
    member inline this.Debug((message: string, a, b, c, d, e, f, g),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b, c, d, e, f, g)) memberName path line

    // ----- 8 args -----
    member inline this.Debug((message: string, a, b, c, d, e, f, g, h),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Debug(message, a, b, c, d, e, f, g, h)) memberName path line

    // ----- INFO -----
    // ----- 0 args -----
    member inline this.Info((message: string),
                  [<Optional>] _ignore: unit,
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message)) memberName path line

    // ----- 1 arg -----
    member inline this.Info((message: string, a),
                      [<Optional>] _ignore: unit,
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a :> obj)) memberName path line

    // ----- 2 args -----
    member inline this.Info((message: string, a, b),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b)) memberName path line

    // ----- 3 args -----
    member inline this.Info((message: string, a, b, c),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b, c)) memberName path line

    // ----- 4 args -----
    member inline this.Info((message: string, a, b, c, d),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b, c, d)) memberName path line

    // ----- 5 args -----
    member inline this.Info((message: string, a, b, c, d, e),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b, c, d, e)) memberName path line

    // ----- 6 args -----
    member inline this.Info((message: string, a, b, c, d, e, f),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b, c, d, e, f)) memberName path line

    // ----- 7 args -----
    member inline this.Info((message: string, a, b, c, d, e, f, g),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b, c, d, e, f, g)) memberName path line

    // ----- 8 args -----
    member inline this.Info((message: string, a, b, c, d, e, f, g, h),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Information(message, a, b, c, d, e, f, g, h)) memberName path line

    // ----- WARNING -----
    // ----- 0 args -----
    member inline this.Warn((message: string),
                  [<Optional>] _ignore: unit,
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message)) memberName path line

    // ----- 1 arg -----
    member inline this.Warn((message: string, a),
                      [<Optional>] _ignore: unit,
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a :> obj)) memberName path line

    // ----- 2 args -----
    member inline this.Warn((message: string, a, b),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b)) memberName path line

    // ----- 3 args -----
    member inline this.Warn((message: string, a, b, c),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b, c)) memberName path line

    // ----- 4 args -----
    member inline this.Warn((message: string, a, b, c, d),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b, c, d)) memberName path line

    // ----- 5 args -----
    member inline this.Warn((message: string, a, b, c, d, e),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b, c, d, e)) memberName path line

    // ----- 6 args -----
    member inline this.Warn((message: string, a, b, c, d, e, f),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b, c, d, e, f)) memberName path line

    // ----- 7 args -----
    member inline this.Warn((message: string, a, b, c, d, e, f, g),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b, c, d, e, f, g)) memberName path line

    // ----- 8 args -----
    member inline this.Warn((message: string, a, b, c, d, e, f, g, h),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Warning(message, a, b, c, d, e, f, g, h)) memberName path line

    // ----- ERROR -----
    // ----- 0 args -----
    member inline this.Error((message: string),
                  [<Optional>] _ignore: unit,
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message)) memberName path line

    // ----- 0 args, ex -----
    member inline this.Error(ex, (message: string),
                  [<Optional>] _ignore: unit,
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex :> exn, message)) memberName path line ex

    // ----- 1 arg -----
    member inline this.Error((message: string, a),
                      [<Optional>] _ignore: unit,
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
       pushPropertiesLogAndReset (lazy Log.Error(message, a :> obj)) memberName path line

    // ----- 1 args, ex -----
    member inline this.Error(ex, (message: string, a),
                  [<Optional>] _ignore: unit,
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex :> exn, message, a :> obj)) memberName path line ex

    // ----- 2 args -----
    member inline this.Error((message: string, a, b),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message, a, b)) memberName path line

    // ----- 2 args, ex -----
    member inline this.Error((ex, message: string, a, b),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex :> exn, message, a, b)) memberName path line ex

    // ----- 3 args -----
    member inline this.Error((message: string, a, b, c),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
      pushPropertiesLogAndReset (lazy Log.Error(message, a, b, c)) memberName path line

    // ----- 3 args, ex -----
    member inline this.Error((ex, message: string, a, b, c),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex :> exn, message, a, b, c)) memberName path line ex

    // ----- 4 args -----
    member inline this.Error((message: string, a, b, c, d),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message, a, b, c, d)) memberName path line

    // ----- 4 args, ex -----
    member inline this.Error((ex, message: string, a, b, c, d),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        let e: exn = ex
        pushPropertiesLogAndResetWithExn (lazy Log.Error(e, message, a, b, c, d)) memberName path line ex

    // ----- 5 args -----
    member inline this.Error((message: string, a, b, c, d, e),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message, a, b, c, d, e)) memberName path line

    // --------- TODO: We need to figure out a way to handle ambiguity between Error-logging functions with ParamArrays

    // ----- 5 args, ex -----
    member inline this.Error((ex: exn, message: string, a, b, c, d, e),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex, message, a, b, c, d, e)) memberName path line ex

    // ----- 6 args -----
    member inline this.Error((message: string, a, b, c, d, e, f),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message, a, b, c, d, e, f)) memberName path line

    // ----- 6 args, ex -----
    member inline this.Error((ex: exn, message: string, a, b, c, d, e, f),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex, message, a, b, c, d, e, f)) memberName path line ex

    // ----- 7 args -----
    member inline this.Error((message: string, a, b, c, d, e, f, g),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message, a, b, c, d, e, f, g)) memberName path line

    // ----- 7 args, ex -----
    member inline this.Error((ex: exn, message: string, a, b, c, d, e, f, g),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex, message, a, b, c, d, e, f, g)) memberName path line ex

    // ----- 8 args -----
    member inline this.Error((message: string, a, b, c, d, e, f, g, h),
                      [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                      [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                      [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndReset (lazy Log.Error(message, a, b, c, d, e, f, g, h)) memberName path line

    // ----- 8 args, ex -----
    member inline this.Error((ex: exn, message: string, a, b, c, d, e, f, g, h),
                  [<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string,
                  [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
                  [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) =
        pushPropertiesLogAndResetWithExn (lazy Log.Error(ex, message, a, b, c, d, e, f, g, h)) memberName path line ex

let L = Logger()
