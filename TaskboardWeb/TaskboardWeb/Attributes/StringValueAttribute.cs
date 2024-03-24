namespace TaskboardWeb.Attributes;

// 参考
// https://qiita.com/sugasaki/items/ea5eec093ad7934abd5c

/// <summary>
/// 文字列値属性
/// </summary>
public class StringValueAttribute : Attribute
{
    /// <summary>
    /// 列挙子に紐づく文字列値
    /// </summary>
    public string StringValue { get; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="value">列挙子に紐づける文字列値</param>
    public StringValueAttribute(string value)
    {
        StringValue = value;
    }
}
