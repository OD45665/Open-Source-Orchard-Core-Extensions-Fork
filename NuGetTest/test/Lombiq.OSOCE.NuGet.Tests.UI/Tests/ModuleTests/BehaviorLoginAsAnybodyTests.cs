using Lombiq.LoginAsAnybody.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lombiq.OSOCE.NuGet.Tests.UI.Tests.ModuleTests;

public class BehaviorLoginAsAnybodyTests : UITestBase
{
    public BehaviorLoginAsAnybodyTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SwitchingUserShouldWorkCorrectly() =>
        ExecuteTestAfterSetupAsync(context => context.SwitchingUserShouldWorkCorrectlyAsync());

    [Fact]
    public Task PermissionCheckShouldWorkCorrectly() =>
        ExecuteTestAfterSetupAsync(
            context => context.PermissionCheckShouldWorkCorrectlyAsync(),
            changeConfiguration: Configurations.IgnoreUnauthorizedBrowserLogEntries);
}
