using CQRSlite.Domain;

namespace S1144FalsePositiveSampleProject;

public class Repository<T> where T : AggregateRoot
{
    private static readonly List<T> Repo = new();

    public void Save(T data)
    {
        Repo.Add(data);
    }

    public T Get(Guid id)
    {
        return Repo.FirstOrDefault(item => item.Id == id);
    }
}