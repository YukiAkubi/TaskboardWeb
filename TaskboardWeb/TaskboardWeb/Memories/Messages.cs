using TaskboardWeb.Constants;
using TaskboardWeb.Database.DataAccessObjects;
using TaskboardWeb.Database.DataTransferObjects;
using TaskboardWeb.Extensions;

namespace TaskboardWeb.Memories;

/// <summary>
/// メッセージを保持するクラス
/// </summary>
public class Messages
{
    /// <summary>
    /// インスタンス
    /// </summary>
    public static Messages Instance { get; } = new Messages();

    /// <summary>
    /// メッセージリスト
    /// </summary>
    private readonly List<MStringsDto> _messages;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private Messages()
    {
        _messages = MStringsDao.Instance.FetchMessages();
    }

    /// <summary>
    /// メッセージコードからメッセージを取得する
    /// </summary>
    /// <param name="code">メッセージコード</param>
    /// <returns>メッセージ</returns>
    public string FindMessage(MessageCodes code) 
    {
        return _messages.Where(m => m.StringCode == code.GetStringValue() && m.LanguageCode == "").First().StringValue;
    }
}
