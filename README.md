🚀 Epic RPC Automation Simulation (C#)

This project simulates an Epic-style RPC automation architecture where a C# test framework communicates with a game backend through a wrapper layer instead of directly invoking game logic.

Instead of tightly coupling automation with engine internals, tests interact through RPC-style service calls — similar to modern game automation pipelines.

🎯 Project Goal

To replicate how large-scale game studios validate gameplay systems using:

Service-based communication

Wrapper-driven automation

Backend gameplay logic validation

This ensures automation mimics real player-driven interactions instead of directly calling engine code.

🧱 Architecture Overview
xUnit Test Layer
        ↓
RPC Wrapper (GameRpcClient)
        ↓
HTTP RPC Request
        ↓
FortniteRPC API (Backend Simulation)
        ↓
Game Logic Execution
        ↓
Response DTO
        ↓
Test Assertions

🔄 End-to-End Flow
1️⃣ Test Scenario Starts

Example:

Potion_Should_Increase_Health()

2️⃣ Wrapper Sends RPC Call

Test uses:

_rpc.UsePotion(50, 20);


Instead of directly calling logic.

3️⃣ RPC Request Sent

API receives:

{
  "startingHealth": 50,
  "amount": 20
}

4️⃣ Backend Executes Logic

Game rules applied:

Health increase

Damage handling

Death detection

5️⃣ Response Returned
{
  "success": true,
  "newHealth": 70
}

6️⃣ Test Validates Behavior
result.NewHealth.Should().Be(70);


Automation confirms gameplay correctness.

📥 Input

Example RPC request:

{
  "startingHealth": 50,
  "amount": 20
}


Simulates:

✔ Player uses potion
✔ Player takes damage

🎮 Processing

Backend applies gameplay rules:

Health increase

Damage reduction

Death validation

📤 Output

Example RPC response:

{
  "success": true,
  "newHealth": 70
}

🧪 Test Suite
Test Case	Scenario	Result
Potion Test	Health increase	✅ Pass
Damage Test	Health reduction	✅ Pass
Death Test	Below zero health	✅ Pass
Health Limit	Bug detection	❌ Fail

The failing test intentionally exposes a gameplay rule violation (health exceeding limits).

📊 Code Coverage

Code coverage was generated using:

Coverlet

ReportGenerator

Coverage validates:

✔ RPC endpoints
✔ Gameplay logic
✔ Success & failure paths

HTML coverage report is included in:

coveragereport/index.html


This ensures automation validates backend behavior effectively.

🔥 Highlights

RPC-style automation flow

Wrapper-based architecture

Integration-level validation

Real gameplay logic testing

Bug detection via failing test

Code coverage enabled

🛠 Tech Stack

ASP.NET Core Web API

xUnit

FluentAssertions

Coverlet

ReportGenerator
