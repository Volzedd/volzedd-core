namespace Volzedd.Telemetry.Processors;

public class ActivityEnricher : BaseProcessor<Activity>
{
	public override void OnEnd(Activity activity)
	{
		foreach (KeyValuePair<string, string> baggage in Baggage.GetBaggage())
		{
			activity.SetTag(baggage.Key, baggage.Value);
		}
	}
}
