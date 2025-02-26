using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using AdvancedLinqAssignment;

[TestClass]
public class PersonRepositoryTests
{
    private PersonRepository repository;

    [TestInitialize]
    public void Setup()
    {
        repository = new PersonRepository();
        repository.InitializeData();
    }

    [TestMethod]
    public void GetPeopleBornAfter_ReturnsCorrectResults()
    {
        var date = new DateTime(2000, 1, 1);
        var result = repository.GetPeopleBornAfter(date);
        Assert.IsTrue(result.All(p => p.Birthday > date));
    }

    [TestMethod]
    public void GetPeopleByName_ReturnsCorrectResults()
    {
        var name = "Person_1234";
        var result = repository.GetPeopleByName(name);
        Assert.IsTrue(result.All(p => p.Name == name));
    }

    [TestMethod]
    public void GetPersonById_ReturnsCorrectPerson()
    {
        var id = 42;
        var result = repository.GetPersonById(id);
        Assert.IsNotNull(result);
        Assert.AreEqual(id, result.Id);
    }

    [TestMethod]
    public void GetPersonById_ReturnsNullForInvalidId()
    {
        var result = repository.GetPersonById(-1);
        Assert.IsNull(result);
    }
}