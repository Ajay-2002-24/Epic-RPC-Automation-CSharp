Epic RPC Automation Simulation (C#)

This project simulates an Epic-style RPC automation architecture where a C# test framework communicates with a game backend through a wrapper layer instead of directly calling game logic.

🎯 Goal

To replicate how large game studios automate gameplay validation by sending RPC-style requests from test frameworks to backend game services.

Architecture
xUnit Test Layer
        ↓
RPC Wrapper (GameRpcClient)
        ↓
HTTP RPC Call
        ↓
FortniteRPC API (Game Backend Simulation)
        ↓
Game Logic Execution
        ↓
Response DTO
        ↓
Test Assertions

📥 Input

Example gameplay action:

{
  "startingHealth": 50,
  "amount": 20
}


Simulates:

Player uses potion

Player takes damage

🎮 Processing

Backend API processes gameplay logic:

Health increase

Damage reduction

Death detection

📤 Output

Example response:

{
  "success": true,
  "newHealth": 70
}


Automation validates this behavior.

🧪 Test Coverage
Test Case	Purpose	Result
Potion Test	Heal player	Pass
Damage Test	Reduce health	Pass
Death Test	Below zero logic	Pass
Health Limit	Bug detection	Fail
🔥 Highlights

RPC-style automation flow

Wrapper-based communication

Integration-level validation

Real bug detection

Code coverage generated

🛠 Tech Stack

ASP.NET Core Web API

xUnit

FluentAssertions

Coverlet

ReportGenerator

💡 Real-World Inspiration

This project demonstrates how automation frameworks interact with service layers in modern game pipelines instead of directly accessing engine code.
