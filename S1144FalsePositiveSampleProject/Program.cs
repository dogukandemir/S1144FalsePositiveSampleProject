using S1144FalsePositiveSampleProject;

var id = Guid.NewGuid();
var repository = new Repository<TestAggregate>();

Initialize();
var afterInitializeStateOfAggregate = repository.Get(id);
Console.WriteLine(afterInitializeStateOfAggregate.TestAggregateData);

Update("Update Event Data");
var lastStateOfTestAggregate = repository.Get(id);
Console.WriteLine(lastStateOfTestAggregate.TestAggregateData);

void Initialize()
{
    var testAggregate = TestAggregate.Create(id);

    repository.Save(testAggregate);
}

void Update(string newTestData)
{
    var testAggregate = repository.Get(id);

    testAggregate.UpdateTestData(newTestData);

    repository.Save(testAggregate);
}