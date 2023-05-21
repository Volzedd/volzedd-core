namespace Volzedd.Data.EntityFramework;

public class DateTimeValueGenerator : ValueGenerator<DateTime>
{
	public override bool GeneratesTemporaryValues => false;

	public override DateTime Next(EntityEntry entry) => DateTime.UtcNow;
}
