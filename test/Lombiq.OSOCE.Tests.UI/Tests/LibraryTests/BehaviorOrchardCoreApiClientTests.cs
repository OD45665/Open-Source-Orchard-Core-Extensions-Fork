using Lombiq.OrchardCoreApiClient.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lombiq.OSOCE.Tests.UI.Tests.LibraryTests;

public class BehaviorOrchardCoreApiClientTests : UITestBase
{
    public BehaviorOrchardCoreApiClientTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

#pragma warning disable xUnit1004 // Test methods should not be skipped
    [Fact(Skip = "Needs https://github.com/OrchardCMS/OrchardCore/issues/17083 to be fixed.")]
#pragma warning restore xUnit1004 // Test methods should not be skipped
    public Task OrchardCoreApiClientShouldWork() =>
        ExecuteTestAfterSetupAsync(context => context.TestOrchardCoreApiClientBehaviorAsync());
}
