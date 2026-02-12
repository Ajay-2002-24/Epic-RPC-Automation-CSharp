using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using XUnitTestProject1.RpcClient;

public class DamageTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly GameRpcClient _rpc;

    public DamageTests(WebApplicationFactory<Program> factory)
    {
        _rpc = new GameRpcClient(factory.CreateClient());
    }

    [Fact]
    public async Task Damage_Should_Reduce_Health()
    {
        var result = await _rpc.TakeDamage(80, 30);

        result.Success.Should().BeTrue();
        result.NewHealth.Should().Be(50);
    }
}
