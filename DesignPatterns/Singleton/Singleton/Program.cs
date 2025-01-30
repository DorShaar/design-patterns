// See https://aka.ms/new-console-template for more information

using Singleton;

Console.WriteLine("Hello, World!");

int value1 = StaticSingleton.Instance.Value;
int value2 = StaticLazySingleton.Instance.Value.Value;