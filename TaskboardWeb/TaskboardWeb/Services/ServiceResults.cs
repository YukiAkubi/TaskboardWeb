namespace TaskboardWeb.Services;

/// <summary>
/// 業務の結果
/// </summary>
public enum ServiceResults
{
    /// <summary>
    /// 成功失敗
    /// </summary>
    Success,

    /// <summary>
    /// 処理の継続をユーザに判断させる
    /// </summary>
    Question,

    /// <summary>
    /// 処理を継続するが警告を出す
    /// </summary>
    Warning,

    /// <summary>
    /// 処理失敗
    /// </summary>
    Error,

    /// <summary>
    /// 処理の継続が困難なエラーが出た
    /// </summary>
    Fatal
}
