using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using XUnitTestProject1.RpcClient;

public class MatchmakingTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly GameRpcClient _rpc;

    public MatchmakingTests(WebApplicationFactory<Program> factory)
    {
        _rpc = new GameRpcClient(factory.CreateClient());
    }

    [Fact]
    public async Task Player_Should_Die_When_Health_Below_Zero()
    {
        var result = await _rpc.TakeDamage(10, 20);

        result.Success.Should().BeFalse();
        result.NewHealth.Should().Be(-10);
    }
}
