using TaskboardWeb.Attributes;

namespace TaskboardWeb.Constants;

/// <summary>
/// メッセージコードの定数クラス
/// </summary>
public enum MessageCodes
{
    /// <summary>
    /// メッセージコード指定なし
    /// </summary>
    [StringValue("")]
    None,

    #region エラーメッセージ

    /// <summary>
    /// ユーザコードが未入力です。
    /// </summary>
    [StringValue("USER_CODE_NOT_INPUTTED")]
    UserCodeNotInputted,

    /// <summary>
    /// パスワードが未入力です。
    /// </summary>
    [StringValue("PASSWORD_NOT_INPUTTED")]
    PasswordNotInputted,

    /// <summary>
    /// ユーザコードが存在しません。
    /// </summary>
    [StringValue("USER_CODE_NOT_FOUND")]
    UserCodeNotFound,

    /// <summary>
    /// パスワードが間違っています。
    /// </summary>
    [StringValue("INVALID_PASSWORD")]
    InvalidPassword,

    #endregion
}
