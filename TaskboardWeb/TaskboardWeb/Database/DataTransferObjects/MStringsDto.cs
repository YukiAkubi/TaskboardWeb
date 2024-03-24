using Microsoft.Data.Sqlite;
using TaskboardWeb.Database.DatabaseConstants;

namespace TaskboardWeb.Database.DataTransferObjects;

/// <summary>
/// 文字列クラスのDTOクラス
/// </summary>
public record MStringsDto
{
    /// <summary>
    /// 文字列種別
    /// <summary>
    public string Kind { get; init; }

    /// <summary>
    /// 文字列コード
    /// <summary>
    public string StringCode { get; init; }

    /// <summary>
    /// 言語コード
    /// <summary>
    public string LanguageCode { get; init; }

    /// <summary>
    /// 文字列値
    /// <summary>
    public string StringValue { get; init; }
    　
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="row">行データ</param>
    public MStringsDto(SqliteDataReader reader)
    {
        Kind = reader[MStringsColumnNames.Kind].ToString() ?? string.Empty;
        StringCode = reader[MStringsColumnNames.StringCode].ToString() ?? string.Empty;
        LanguageCode = reader[MStringsColumnNames.LanguageCode].ToString() ?? string.Empty;
        StringValue = reader[MStringsColumnNames.String].ToString() ?? string.Empty;
    }
}
