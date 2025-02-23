using Lombiq.Hosting.MediaTheme.Bridge.Tests.UI.Extensions;
using Lombiq.Hosting.MediaTheme.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lombiq.OSOCE.NuGet.Tests.UI.Tests.ThemeTests;

public class BehaviorMediaThemeTests : UITestBase
{
    public BehaviorMediaThemeTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task MediaThemeShouldRenderTemplatesFromMediaLibrary() =>
        ExecuteTestAfterSetupAsync(context => context.TestMediaThemeDeployedBehaviorAsync());

    [Fact]
    public Task MediaThemeTemplateAccessShouldBeBlocked() =>
        ExecuteTestAfterSetupAsync(async context => await context.TestMediaThemeTemplatePageAsync());
}
