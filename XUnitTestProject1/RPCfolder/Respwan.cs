using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using XUnitTestProject1.RpcClient;

public class Respwan : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly GameRpcClient _rpc;

    public Respwan(WebApplicationFactory<Program> factory)
    {
        _rpc = new GameRpcClient(factory.CreateClient());
    }

    [Fact]
    public async Task Health_Should_Not_Exceed_100()
    {
        var result = await _rpc.UsePotion(95, 10);

        result.NewHealth.Should().BeLessOrEqualTo(100); // Will FAIL (105)
    }
}
