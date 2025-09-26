namespace MyMonkeyApp.Models;

/// <summary>
/// 원숭이 정보를 나타내는 모델 클래스
/// </summary>
public class Monkey
{
    /// <summary>
    /// 원숭이 이름
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 서식지
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// 개체수
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// ASCII 아트 (선택)
    /// </summary>
    public string? AsciiArt { get; set; }
}
