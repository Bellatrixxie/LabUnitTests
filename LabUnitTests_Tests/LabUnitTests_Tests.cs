using NUnit.Framework;
using LabUnitTests;

namespace LabUnitTests_Tests
{
    public class Classification_Tests
    {
        [TestCase(7, "U films are available. PG films are available, Parent Guidance advised.")]
        [TestCase(8, "U & PG films are available.")]
        [TestCase(11, "U & PG films are available.")]
        [TestCase(12, "U, PG & 12 films are available.")]
        [TestCase(14, "U, PG & 12 films are available.")]
        [TestCase(15, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, "U & PG films are available.")]
        public void GivenAgeOfViewer_AvailableClassifications_returnsCorrectMessage(int age, string expResult)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expResult));
        }
    }
}