using Microsoft.Data.Sqlite;
using System.Text;
using TaskboardWeb.Database.DataTransferObjects;
using TaskboardWeb.Memories;

namespace TaskboardWeb.Database.DataAccessObjects;

/// <summary>
/// 文字列マスタのDAOクラス
/// </summary>
public class MStringsDao
{
    /// <summary>
    /// インスタンス
    /// </summary>
    public static MStringsDao Instance { get; } = new MStringsDao();

    /// <summary>
    /// SQLiteへの接続オブジェクト
    /// </summary>
    private readonly SqliteConnection _connection;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private MStringsDao()
    {
        // 接続オブジェクトを作成
        _connection = new SqliteConnection(AppSettings.Instance.ConnectionStrings.TaskboardServer);
    }

    /// <summary>
    /// 文字列マスタからメッセージを取得する
    /// </summary>
    /// <returns>取得したデータ</returns>
    public List<MStringsDto> FetchMessages() 
    {
        // 戻り値準備
        var result = new List<MStringsDto>();

        try
        {
            // SQL作成
            var sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("    KIND");
            sql.Append("    , STRING_CODE");
            sql.Append("    , LANGUAGE_CODE");
            sql.Append("    , STRING ");
            sql.Append("FROM");
            sql.Append("    M_STRINGS ");
            sql.Append("WHERE");
            sql.Append("    KIND = 'MESSAGE'");

            // コマンド作成
            _connection.Open();
            using var command = new SqliteCommand(sql.ToString(), _connection);

            // SQL実行
            var reader = command.ExecuteReader();

            // DTOに変換
            while (reader.Read())
            {
                result.Add(new MStringsDto(reader));
            }
        }
        catch
        {
            throw;
        }
        finally
        {
            _connection.Close();
        }

        return result;
    }
}
