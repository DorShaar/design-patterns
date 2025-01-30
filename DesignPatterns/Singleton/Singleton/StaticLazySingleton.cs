namespace Singleton;

public class StaticLazySingleton
{
	public int Value { get; set; } = 3;

	public static Lazy<StaticSingleton> Instance { get; } = new();

	private StaticLazySingleton()
	{
	}
}