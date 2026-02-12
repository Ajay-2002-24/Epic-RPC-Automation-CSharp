using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using XUnitTestProject1.RpcClient;

public class PotionTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly GameRpcClient _rpc;

    public PotionTests(WebApplicationFactory<Program> factory)
    {
        _rpc = new GameRpcClient(factory.CreateClient());
    }

    [Fact]
    public async Task Potion_Should_Increase_Health()
    {
        var result = await _rpc.UsePotion(40, 20);

        result.Success.Should().BeTrue();
        result.NewHealth.Should().Be(60);
    }
}
