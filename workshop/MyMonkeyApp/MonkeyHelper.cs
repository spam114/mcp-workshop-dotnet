using MyMonkeyApp.Models;

namespace MyMonkeyApp;

/// <summary>
/// Monkey 데이터 관리용 static 헬퍼 클래스
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Japanese Macaque", Location = "Japan", Population = 100000 },
        new Monkey { Name = "Golden Snub-nosed Monkey", Location = "China", Population = 15000 },
        new Monkey { Name = "Proboscis Monkey", Location = "Borneo", Population = 7000 },
        new Monkey { Name = "Mandrill", Location = "Central Africa", Population = 10000 },
        new Monkey { Name = "Spider Monkey", Location = "Central/South America", Population = 25000 }
    };

    private static int randomPickCount = 0;

    /// <summary>
    /// 모든 Monkey 목록 반환
    /// </summary>
    public static List<Monkey> GetMonkeys() => monkeys;

    /// <summary>
    /// 이름으로 Monkey 찾기
    /// </summary>
    public static Monkey? GetMonkeyByName(string name)
    {
        return monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// 랜덤 Monkey 반환 및 접근 횟수 증가
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        var rand = new Random();
        randomPickCount++;
        return monkeys[rand.Next(monkeys.Count)];
    }

    /// <summary>
    /// 랜덤 Monkey 선택 횟수 반환
    /// </summary>
    public static int GetRandomPickCount() => randomPickCount;
}
