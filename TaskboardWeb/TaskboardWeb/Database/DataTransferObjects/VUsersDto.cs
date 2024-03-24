using Microsoft.Data.Sqlite;
using TaskboardWeb.Database.DatabaseConstants;

namespace TaskboardWeb.Database.DataTransferObjects;

/// <summary>
/// ユーザビューのDTOクラス
/// </summary>
public record VUsersDto
{
    /// <summary>
    /// ユーザコード
    /// <summary>
    public string UserCode { get; init; }

    /// <summary>
    /// パスワード
    /// <summary>
    public string Password { get; init; }

    /// <summary>
    /// 利用言語
    /// <summary>
    public string UserLanguage { get; init; }

    /// <summary>
    /// 言語コード
    /// <summary>
    public string LanguageCode { get; init; }

    /// <summary>
    /// ユーザ名
    /// <summary>
    public string UserName { get; init; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="row">行データ</param>
    public VUsersDto(SqliteDataReader reader) 
    {
        UserCode = reader[VUsersColumnNames.UserCode].ToString() ?? string.Empty;
        Password = reader[VUsersColumnNames.Password].ToString() ?? string.Empty;
        UserLanguage = reader[VUsersColumnNames.UserLanguage].ToString() ?? string.Empty;
        LanguageCode = reader[VUsersColumnNames.LanguageCode].ToString() ?? string.Empty;
        UserName = reader[VUsersColumnNames.UserName].ToString() ?? string.Empty;
    }
}
