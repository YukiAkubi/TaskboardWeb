using TaskboardWeb.Attributes;

namespace TaskboardWeb.Extensions;

// 参考
// https://qiita.com/sugasaki/items/ea5eec093ad7934abd5c

/// <summary>
/// 列挙型の拡張メソッド群
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// 列挙子に紐づいている文字列値を返す
    /// </summary>
    /// <param name="value">列挙子</param>
    /// <returns>列挙子に紐づく文字列値</returns>
    public static string GetStringValue(this Enum value)
    {
        // 列挙子の型を取得し、フィールド情報を取得する
        var fieldInfo = value.GetType().GetField(value.ToString());

        // フィールド情報が存在しない場合は空文字を返す
        if (fieldInfo is null)
        { 
            return string.Empty; 
        }

        // カスタム属性StringValueAttributeの値を取得する
        var attributes = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

        // 列挙子に紐づいている文字列値を返す
        return attributes is not null && attributes.Length > 0 ? attributes.First().StringValue : string.Empty;
    }
}
