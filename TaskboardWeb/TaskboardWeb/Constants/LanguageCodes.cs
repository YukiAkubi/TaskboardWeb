using TaskboardWeb.Attributes;

namespace TaskboardWeb.Constants;

/// <summary>
/// 言語コード
/// </summary>
public enum LanguageCodes
{
    /// <summary>
    /// 日本語
    /// </summary>
    [StringValue("ja-JP")]
    Japanese,

    /// <summary>
    /// English
    /// </summary>
    [StringValue("en-US")]
    EnglishUS,

    /// <summary>
    /// 大陆简体
    /// </summary>
    [StringValue("zh-JP")]
    ShimplizedChinese,

    /// <summary>
    /// 臺灣正體
    /// </summary>
    [StringValue("zh-TW")]
    TraditionalChinese,

    /// <summary>
    /// 한국어
    /// </summary>
    [StringValue("ko-KR")]
    Korean,
}
