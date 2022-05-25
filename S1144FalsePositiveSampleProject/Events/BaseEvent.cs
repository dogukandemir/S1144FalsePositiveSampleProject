using CQRSlite.Events;

namespace S1144FalsePositiveSampleProject.Events;

public abstract class BaseEvent : IEvent
{
    public Guid Id { get; set; }
    public int Version { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}