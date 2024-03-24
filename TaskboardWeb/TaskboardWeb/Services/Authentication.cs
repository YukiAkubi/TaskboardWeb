using TaskboardWeb.Constants;
using TaskboardWeb.Database.DataAccessObjects;

namespace TaskboardWeb.Services;

/// <summary>
/// ユーザ認証業務
/// </summary>
public class Authentication
{
    /// <summary>
    /// インスタンス
    /// </summary>
    public static Authentication Instance { get; } = new Authentication();

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private Authentication() { }

    /// <summary>
    /// ログインを実施する
    /// </summary>
    /// <param name="userCode">ユーザコード</param>
    /// <param name="password">パスワード</param>
    /// <returns>処理結果</returns>
    public ServiceResult Login(string userCode, string password) 
    {
        // 入力チェック
        if (string.IsNullOrWhiteSpace(userCode))
        {
            return new ServiceResult(ServiceResults.Error, MessageCodes.UserCodeNotInputted);
        }
        if(string.IsNullOrWhiteSpace(password))
        {
            return new ServiceResult(ServiceResults.Error, MessageCodes.PasswordNotInputted);
        }

        // ユーザデータを取得する
        var users = VUsersDao.Instance.FindUser(userCode);

        // 取得件数が0件の場合はエラー
        if (users is null || users.Count == 0)
        {
            return new ServiceResult(ServiceResults.Error, MessageCodes.UserCodeNotFound);
        }
        // パスワードが誤っている場合はエラー
        if (users.First().Password != password)
        {
            return new ServiceResult(ServiceResults.Error, MessageCodes.InvalidPassword);
        }

        // ログイン処理を実施する


        // ログイン成功として返す
        return new ServiceResult();
    }
}
