using TaskboardWeb.Constants;

namespace TaskboardWeb.Memories;

/// <summary>
/// ログイン情報
/// </summary>
public class LoginInformations
{
    /// <summary>
    /// インスタンス
    /// </summary>
    public static LoginInformations Instance { get; } = new LoginInformations();

    /// <summary>
    /// ログイン言語
    /// </summary>
    public LanguageCodes LanguageCode { get; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private LoginInformations()
    {
        // 言語の初期設定は日本語
        LanguageCode = LanguageCodes.Japanese;
    }
}
