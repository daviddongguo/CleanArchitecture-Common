using System;
using Moq;
using NUnit.Framework;

namespace Clean.Architecture.SharedKernel.UnitTests;
[TestFixture]
public class BaseDomainEventConstructor
{
  private BaseDomainEvent? _testEvent;

  [SetUp]
  public void Init()
  {
    _testEvent = new Mock<BaseDomainEvent>().Object;
  }

  [TestCase()]
  public void InitializesDataOccurred()
  {
    Assert.IsNotNull(_testEvent?.DateOccurred);
    Assert.IsInstanceOf<DateTime>(_testEvent?.DateOccurred);
    Assert.That(_testEvent?.DateOccurred, Is.LessThan(DateTime.UtcNow));
  }
}
