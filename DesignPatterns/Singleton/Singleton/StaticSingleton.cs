namespace Singleton;

public class StaticSingleton
{
	public int Value { get; set; } = 3;

	public static StaticSingleton Instance { get; } = new();

	private StaticSingleton()
	{
	}
}