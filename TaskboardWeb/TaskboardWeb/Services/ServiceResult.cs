using TaskboardWeb.Constants;

namespace TaskboardWeb.Services;

/// <summary>
/// 業務ロジックの結果
/// </summary>
public record ServiceResult
{
    /// <summary>
    /// 処理結果
    /// </summary>
    public ServiceResults Result { get; }

    ///// <summary>
    ///// 戻すオブジェクト
    ///// </summary>
    //public T Value { get; }

    /// <summary>
    /// メッセージ
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ServiceResult()
    {
        Result = ServiceResults.Success;
        Message = string.Empty;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="result">処理結果</param>
    /// <param name="message">メッセージ</param>
    /// <param name="args">メッセージを補完する文字列</param>
    public ServiceResult(ServiceResults result, MessageCodes message, params object[] args)
    {
        Result = result;
        Message = string.Empty;
    }
}
