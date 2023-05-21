namespace Volzedd.Telemetry.Processors;

public class LogEnricher : BaseProcessor<LogRecord>
{
	public override void OnEnd(LogRecord log)
	{
		if (log.StateValues == null)
		{
			log.StateValues = Baggage.GetBaggage().Select(b =>
			{
				return new KeyValuePair<string, object?>(b.Key, b.Value);
			}).ToList();
		}
		else
		{
			log.StateValues = log.StateValues.Union(Baggage.GetBaggage().Select(b =>
			{
				return new KeyValuePair<string, object?>(b.Key, b.Value);
			})).ToList();
		}
	}
}
