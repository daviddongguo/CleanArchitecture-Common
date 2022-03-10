using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Clean.Architecture.SharedKernel.UnitTests;
class Customer : ValueObject
{
  public string Name { get; set; }
  public int Age;

  private readonly int ssn;  //ignored in comparisons

  [IgnoreMember]
  public string Address;  //also ignored because of attribute

  public Customer() { }
  public Customer(string name, int age, int ssn, string address)
  {
    Name = name;
    Age = age;
    this.ssn = ssn;
    Address = address;
  }
}

[TestFixture]
public class IgnoreMemberAttributeTest
{
  [TestCase()]
  public void IgnoreMember_Property_DoesNotConsider()
  {
    var customer1 = new Customer { Name = "John", Age = 13, Address = "California" };
    var customer2 = new Customer { Name = "John", Age = 13, Address = "Florida" };

    Assert.IsTrue(customer1.Equals(customer2));
  }

  [TestCase()]
  public void IgnoreMember_Field_DoesNotConsider()
  {
    var customer1 = new Customer("John", 13, 123, "California");
    var customer2 = new Customer("John", 13, 456, "florida");

    Assert.IsTrue(customer1.Equals(customer2));
  }
}
