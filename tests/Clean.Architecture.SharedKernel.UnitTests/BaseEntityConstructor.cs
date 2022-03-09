using System;
using Moq;
using NUnit.Framework;

namespace Clean.Architecture.SharedKernel.UnitTests;

[TestFixture]
public class BaseEntityConstructor
{
  private BaseEntity? _testEntity;

  [SetUp]
  public void Init()
  {
    _testEntity = new Mock<BaseEntity>().Object;
  }

  [TestCase()]
  public void InitializesId()
  {
    Assert.NotNull(_testEntity?.Id);
    Assert.True(Guid.TryParse(_testEntity?.Id.ToString(), out _));
  }
  [TestCase()]
  public void InitializesEventsToEmptyList()
  {
    Assert.That(_testEntity?.Events, Is.Not.Null);
    Assert.That(_testEntity?.Events, Is.Empty);
  }

}
