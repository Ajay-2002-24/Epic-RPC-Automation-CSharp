using FortniteRPC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject1.RpcClient;

public class GameRpcClient
{
    private readonly HttpClient _http;

    public GameRpcClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<Response> UsePotion(int health, int amount)
    {
        var res = await _http.PostAsJsonAsync("/api/RPC/use-potion",
            new Request { StartingHealth = health, Amount = amount });

        return await res.Content.ReadFromJsonAsync<Response>();
    }

    public async Task<Response> TakeDamage(int health, int amount)
    {
        var res = await _http.PostAsJsonAsync("/api/RPC/take-damage",
            new Request { StartingHealth = health, Amount = amount });

        return await res.Content.ReadFromJsonAsync<Response>();
    }
}
