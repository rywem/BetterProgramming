## Workspace Contents
1. [MasterUnitTesting](./MasterUnitTesting) - a workspace to learn more about test driven development. Based upon the Udemy course [Master C# NUnit and Moq](https://www.udemy.com/nunit-moq/learn/)
2. [UnitTestMosh](./UnitTestMosh) - another series for learning unit tests. [Unit Testing in C#](./https://www.udemy.com/unit-testing-csharp/learn/v4/) by Mosh Hamedani.

## Quick reference

1. Different approaches for asserting values in an array exist.  
```
Assert.That(result, Is.Not.Empty);
Assert.That(result.Count, Is.EqualTo(3));
Assert.That(result, Does.Contain(1));
Assert.That(result, Does.Contain(3));
Assert.That(result, Does.Contain(5));
Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
Assert.That(result, Is.Ordered); //ordered
Assert.That(result, Is.Unique); //checks that there aren't any duplicates
```
2. Asserting values in a string
```
StringAssert.StartsWith("hello", result);
Assert.That(result, Is.EqualTo("hello"));
```
