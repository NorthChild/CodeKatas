using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeKata3_GroupedByCommas;

namespace TestingCodeKata3Solution.Happy_Paths
{
    public class GivenAnIntReturnRightGorupingByCommas
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void GetPositiveIntegersAndReturnGroupedByComma()
            {
                Assert.That(Program.GroupByMethod(1), Is.EqualTo("1"));
                Assert.That(Program.GroupByMethod(12), Is.EqualTo("12"));
                Assert.That(Program.GroupByMethod(123), Is.EqualTo("123"));
                Assert.That(Program.GroupByMethod(1234), Is.EqualTo("1,234"));
                Assert.That(Program.GroupByMethod(12345), Is.EqualTo("12,345"));
                Assert.That(Program.GroupByMethod(123456), Is.EqualTo("123,456"));
                Assert.That(Program.GroupByMethod(1234567), Is.EqualTo("1,234,567"));
                Assert.That(Program.GroupByMethod(12345678), Is.EqualTo("12,345,678"));
                Assert.That(Program.GroupByMethod(123456789), Is.EqualTo("123,456,789"));
                Assert.That(Program.GroupByMethod(1234567890), Is.EqualTo("1,234,567,890"));
            }


            [Test]
            public void GetNegativeIntegersAndReturnGroupedByComma()
            {
                Assert.That(Program.GroupByMethod(-1), Is.EqualTo("-1"));
                Assert.That(Program.GroupByMethod(-12), Is.EqualTo("-12"));
                Assert.That(Program.GroupByMethod(-123), Is.EqualTo("-123"));
                Assert.That(Program.GroupByMethod(-1234), Is.EqualTo("-1,234"));
                Assert.That(Program.GroupByMethod(-12345), Is.EqualTo("-12,345"));
                Assert.That(Program.GroupByMethod(-123456), Is.EqualTo("-123,456"));
                Assert.That(Program.GroupByMethod(-1234567), Is.EqualTo("-1,234,567"));
                Assert.That(Program.GroupByMethod(-12345678), Is.EqualTo("-12,345,678"));
                Assert.That(Program.GroupByMethod(-123456789), Is.EqualTo("-123,456,789"));
                Assert.That(Program.GroupByMethod(-1234567890), Is.EqualTo("-1,234,567,890"));
            }
        }
    }
}
