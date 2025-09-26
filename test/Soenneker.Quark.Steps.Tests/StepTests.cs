using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Steps.Tests;

[Collection("Collection")]
public sealed class StepTests : FixturedUnitTest
{
    public StepTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
