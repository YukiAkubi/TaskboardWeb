namespace TaskboardWeb.Memories;

/// <summary>
/// 接続文字列に関する設定項目
/// </summary>
public class ConnectionStrings
{
    /// <summary>
    /// タスクボードアプリケーションのデータベースサーバ
    /// </summary>
    public string TaskboardServer { get; init; } = string.Empty;
}
