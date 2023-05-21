namespace Volzedd.Core.Configuration;

public static class Extensions
{
	public static T GetValueOrThrow<T>(this IConfiguration configuration, string key)
	{
		return configuration.GetValue<T>(key) ?? throw new Exception($"Could not read configuration value '{key}'");
	}
}
