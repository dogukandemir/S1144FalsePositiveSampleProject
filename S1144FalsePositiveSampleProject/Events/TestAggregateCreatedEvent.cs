namespace S1144FalsePositiveSampleProject.Events;

public class TestAggregateCreatedEvent : BaseEvent
{
    public string InitialTestData { get; set; }
}