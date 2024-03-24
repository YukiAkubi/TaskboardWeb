namespace TaskboardWeb.Memories;

/// <summary>
/// appsettings.jsonファイルの値にアクセスするクラス
/// </summary>
public class AppSettings
{
    /// <summary>
    /// 設定ファイル名
    /// </summary>
    private const string APP_SETTINGS_FILE_NAME = "appsettings.json";

    /// <summary>
    /// 接続文字列に関するキー
    /// </summary>
    private const string CONNECTION_STRINGS = "ConnectionStrings";

    /// <summary>
    /// インスタンス
    /// </summary>
    public static AppSettings Instance { get; } = new AppSettings();

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private AppSettings() 
    {
        ConnectionStrings = new ConfigurationBuilder().AddJsonFile(APP_SETTINGS_FILE_NAME).Build().GetSection(CONNECTION_STRINGS).Get<ConnectionStrings>() ?? throw new NullReferenceException();
    }

    /// <summary>
    /// 接続文字列に関する設定
    /// </summary>
    public ConnectionStrings ConnectionStrings { get; }
}
