

using MyMonkeyApp;
using MyMonkeyApp.Models;

var asciiArts = new[]
{
	@"  (\__/)",
	@"  (o.o )",
	@"  (> < )",
	@"  /\_/\",
	@" ( ' . ' )",
	@" ( : : )",
	@" ( _ )"
};

while (true)
{
	Console.WriteLine("\n===== Monkey Console App =====");
	Console.WriteLine("1. List all monkeys");
	Console.WriteLine("2. Get details for a specific monkey by name");
	Console.WriteLine("3. Get a random monkey");
	Console.WriteLine("4. Exit app");
	Console.Write("Select an option: ");
	var input = Console.ReadLine();

	switch (input)
	{
		case "1":
			var monkeys = MonkeyHelper.GetMonkeys();
			Console.WriteLine("\n| 이름                  | 서식지                | 개체수   |");
			Console.WriteLine("|-----------------------|-----------------------|----------|");
			foreach (var monkey in monkeys)
			{
				Console.WriteLine($"| {monkey.Name,-21} | {monkey.Location,-21} | {monkey.Population,8} |");
			}
			break;
		case "2":
			Console.Write("\nEnter monkey name: ");
			var name = Console.ReadLine();
			var found = MonkeyHelper.GetMonkeyByName(name ?? "");
			if (found != null)
			{
				Console.WriteLine($"\nName: {found.Name}\nLocation: {found.Location}\nPopulation: {found.Population}");
			}
			else
			{
				Console.WriteLine("Monkey not found.");
			}
			break;
		case "3":
			var randomMonkey = MonkeyHelper.GetRandomMonkey();
			var rand = new Random();
			var art = asciiArts[rand.Next(asciiArts.Length)];
			Console.WriteLine($"\n{art}");
			Console.WriteLine($"Random Monkey: {randomMonkey.Name}\nLocation: {randomMonkey.Location}\nPopulation: {randomMonkey.Population}");
			Console.WriteLine($"(Random monkey picked {MonkeyHelper.GetRandomPickCount()} times)");
			break;
		case "4":
			Console.WriteLine("Exiting app. Bye!");
			return;
		default:
			Console.WriteLine("Invalid option. Try again.");
			break;
	}
}
