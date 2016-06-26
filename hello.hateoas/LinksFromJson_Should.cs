using FluentAssertions;
using NEdifis.Attributes;
using NUnit.Framework;

namespace hello.hateoas
{
    [TestFixtureFor(typeof (LinksFromJson))]
    // ReSharper disable once InconsistentNaming
    internal class LinksFromJson_Should
    {
        [Test]
        public void GetLinksFromJson()
        {
            var sut = new LinksFromJson();
            foreach (var testCase in TestData.TestCases)
            {
                var actual = sut.GetLinks(testCase.Input, testCase.Pattern);
                actual.ShouldAllBeEquivalentTo(testCase.Expected);
            }
        }
    }
}