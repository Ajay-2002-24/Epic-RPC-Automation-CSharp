# Epic RPC Automation Simulation (C#)

This project demonstrates how gameplay automation can be performed without directly interacting with engine code.

Instead of calling game logic internally, C# automation tests communicate with gameplay systems through a wrapper-based RPC layer — similar to how enterprise game pipelines isolate automation from core engine code.

# Objective

Simulate an Epic-style automation approach where:

C# test frameworks validate gameplay behavior

Engine logic remains untouched

Communication happens through service-level RPC calls

This enables safe, scalable automation without coupling tests to engine implementation.

# Automation Architecture

Automation does not directly invoke gameplay logic.

Instead, the flow is:

C# xUnit Tests
      ↓
RPC Wrapper (GameRpcClient)
      ↓
HTTP RPC Call
      ↓
Backend Gameplay Service (FortniteRPC API)
      ↓
Game Logic Execution
      ↓
Response DTO
      ↓
Test Assertions

# Step 1 — Test Layer

Automation initiates gameplay action:

UsePotion(50, 20)

# Step 2 — Wrapper Layer

Wrapper converts test intent into RPC request.

# Step 3 — RPC Communication

Request sent to gameplay service:

{
  "startingHealth": 50,
  "amount": 20
}

# Step 4 — Gameplay Logic

Backend simulates:

Health increase

Damage handling

Death validation

# Step 5 — Response

System returns:

{
  "success": true,
  "newHealth": 70
}

# Step 6 — Assertion

Automation validates behavior — without touching engine code.

# Test Coverage
Test Case	Scenario	Result
Potion Test	Health increase	Pass
Damage Test	Health reduction	Pass
Death Test	Health below zero	Pass
Health Limit	Overflow detection	Fail
Test Results Snapshot
<p align="center"> <img src="https://github.com/Ajay-2002-24/Epic-RPC-Automation-CSharp/raw/main/C%23%20RPC%20Testcase.jpg" width="800"/> </p>

The failing test exposes a gameplay edge case — showcasing real validation capability.

# Code Coverage

Generated using: Coverlet , ReportGenerator
Run:
dotnet test --collect:"XPlat Code Coverage"
Coverage report available in: coveragereport/index.html


 # Tech Stack

ASP.NET Core Web API
xUnit
FluentAssertions
Coverlet
ReportGenerator

# Why This Matters

In large-scale game environments:

Automation should not modify or depend on engine internals

Tests must interact through stable service interfaces

This project simulates that model using:

✔ Wrapper-driven interaction
✔ RPC-based communication
✔ Engine isolation

# Outcome

Gameplay behavior is validated through service communication, enabling decoupled and scalable automation.
