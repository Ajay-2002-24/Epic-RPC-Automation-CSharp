Epic RPC Automation Simulation (C#)

A service-driven automation framework that simulates how modern game automation systems interact with backend gameplay services using RPC-style communication.

This project demonstrates how a C# automation layer validates gameplay logic by communicating through a wrapper instead of directly invoking backend logic.

It includes:

ASP.NET Core RPC-style API

xUnit automation tests

Wrapper-based communication

Integrated code coverage reporting

Features

RPC-style automation architecture

Wrapper-driven service communication

Backend gameplay logic simulation

xUnit test integration

Code coverage reports (Coverlet + ReportGenerator)

Real bug detection through failing test scenario

Architecture Overview

Automation does not directly call logic.

Instead, communication happens through an RPC layer.

xUnit Test Layer
        ↓
RPC Wrapper (GameRpcClient)
        ↓
HTTP RPC Call
        ↓
FortniteRPC API
        ↓
Game Logic Execution
        ↓
Response DTO
        ↓
Test Assertions

How It Works
Input

Automation sends gameplay action request:

{
  "startingHealth": 50,
  "amount": 20
}


Simulates:

Player using potion

Player taking damage

Processing

Backend API processes gameplay rules:

Health increase

Damage handling

Death detection

Output

System returns updated state:

{
  "success": true,
  "newHealth": 70
}


Automation validates this behavior through assertions.

Test Coverage
Test Case	Scenario	Result
Potion Test	Health increase	Pass
Damage Test	Health reduction	Pass
Death Test	Health below zero	Pass
Health Limit	Detect overflow bug	Fail

The failing test intentionally highlights an edge case violation in gameplay logic.

Code Coverage

Integrated using:

Coverlet

ReportGenerator

Run:

dotnet test --collect:"XPlat Code Coverage"


Generate HTML report:

reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coveragereport -reporttypes:Html


Open:

coveragereport/index.html

Project Structure
FortniteRPC1        → Backend RPC API
XUnitTestProject1   → Automation Layer
RpcClient           → Wrapper Communication
coveragereport      → Code Coverage Output

Getting Started
1. Clone Repository
git clone <repo-url>

2. Install Dependencies
dotnet restore

3. Run API
dotnet run --project FortniteRPC1

4. Run Tests
dotnet test

5. Run Tests with Coverage
dotnet test --collect:"XPlat Code Coverage"

Tech Stack

ASP.NET Core Web API

xUnit

FluentAssertions

Coverlet

ReportGenerator

Purpose

This project demonstrates a service-based automation pattern where gameplay behavior is validated through RPC communication instead of direct logic invocation.

This approach improves:

Test reliability

System decoupling

Real-world scenario validation

Outcome

The system successfully validates gameplay rules through RPC communication and highlights behavioral edge cases via automated testing and coverage reporting.
