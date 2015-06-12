using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Core;
using FluentAssertions;
using Xunit;

namespace Core.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Constructor_SetsProperties_WhenPropertiesAreValid()
        {
            var issue = new Issue("Foo", 1001, "Firmware Update", DateTime.Today);
            Assert.Equal("Foo", Issue.ClientName); // using xunit assertion
            Issue.Title.Should().Be("Firmware Update"); // using fluent assertion
        }
    }
}
