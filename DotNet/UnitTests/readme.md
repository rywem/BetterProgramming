## Workspace Contents
1. [MasterUnitTesting](./MasterUnitTesting) - a workspace to learn more about test driven development. Based upon the Udemy course [Master C# NUnit and Moq](https://www.udemy.com/nunit-moq/learn/)
2. [UnitTestMosh](./UnitTestMosh) - another series for learning unit tests. [Unit Testing in C#](./https://www.udemy.com/unit-testing-csharp/learn/v4/) by Mosh Hamedani.

## Packages

- install-package NUnit -Version 3.8.1
- install-package NUnit3TestAdapter -Version 3.8.0


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
3. Test exception(s) thrown
```
Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
Assert.That(() => _calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
var ex = Assert.Throws<ArgumentException>(() => Account.Deposit(-1));
```
