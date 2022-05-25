using CQRSlite.Domain;
using S1144FalsePositiveSampleProject.Events;

namespace S1144FalsePositiveSampleProject;

public class TestAggregate : AggregateRoot
{
    public string TestAggregateData { get; set; }

    public static TestAggregate Create(Guid id)
    {
        var testAggregate = new TestAggregate
        {
            Id = id
        };

        testAggregate.ApplyChange(new TestAggregateCreatedEvent
        {
            InitialTestData = "Created Event Data"
        });

        return testAggregate;
    }

    public void UpdateTestData(string newTestData)
    {
        ApplyChange(new UpdateTestDataEvent
        {
            TestEventData = newTestData
        });
    }

    private void Apply(UpdateTestDataEvent @event)
    {
        TestAggregateData = @event.TestEventData;
    }

    private void Apply(TestAggregateCreatedEvent @event)
    {
        TestAggregateData = @event.InitialTestData;
    }
}