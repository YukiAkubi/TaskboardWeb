using Microsoft.Data.Sqlite;
using System.Text;
using TaskboardWeb.Database.DataTransferObjects;
using TaskboardWeb.Memories;

namespace TaskboardWeb.Database.DataAccessObjects;

/// <summary>
/// ユーザビューのDAOクラス
/// </summary>
public class VUsersDao
{
    /// <summary>
    /// ユーザビューのDAOクラスのインスタンス
    /// </summary>
    public static VUsersDao Instance { get; } = new VUsersDao();

    /// <summary>
    /// SQLiteへの接続オブジェクト
    /// </summary>
    private readonly SqliteConnection _connection;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private VUsersDao() 
    {
        // 接続オブジェクトを作成
        _connection = new SqliteConnection(AppSettings.Instance.ConnectionStrings.TaskboardServer);
    }

    /// <summary>
    /// ユーザデータを一人分取得する
    /// </summary>
    /// <param name="userCode">ユーザコード</param>
    /// <returns>取得したデータ</returns>
    public List<VUsersDto> FindUser(string userCode)
    {
        // 戻り値準備
        var result = new List<VUsersDto>();

        try
        {
            // SQL作成
            var sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("    USER_CODE");
            sql.Append("    , PASSWORD");
            sql.Append("    , USER_LANGUAGE");
            sql.Append("    , LANGUAGE_CODE");
            sql.Append("    , USER_NAME ");
            sql.Append("FROM");
            sql.Append("    V_USERS ");
            sql.Append("WHERE");
            sql.Append("    USER_CODE = @USER_CODE ");

            // コマンド作成
            _connection.Open();
            using var command = new SqliteCommand(sql.ToString(), _connection);

            // パラメータ作成
            command.Parameters.AddWithValue("@USER_CODE", userCode);

            // SQL実行
            var reader = command.ExecuteReader();

            // DTOに変換
            while (reader.Read())
            {
                result.Add(new VUsersDto(reader));
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
