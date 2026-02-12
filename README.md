# Epic RPC Automation Simulation (C#)

A service-driven automation framework that simulates how C# test systems interact with backend gameplay services using RPC-style communication.

Instead of directly calling logic, automation communicates through a wrapper layer — enabling realistic gameplay validation.

Features

# RPC-style automation architecture

Wrapper-based service communication

Backend gameplay logic simulation

xUnit test integration

Code coverage reporting (Coverlet + ReportGenerator)

Edge-case bug detection via failing test

# Architecture
xUnit Tests
   ↓
RPC Wrapper (GameRpcClient)
   ↓
HTTP RPC Call
   ↓
FortniteRPC API
   ↓
Game Logic
   ↓
Response DTO
   ↓
Assertions

# Input
Example request:

{
  "startingHealth": 50,
  "amount": 20
}


Simulates gameplay actions such as potion usage or damage.

# Output
Example response:

{
  "success": true,
  "newHealth": 70
}


# Validated through automated tests.

Test Coverage
Test Case	Scenario	Result
Potion Test	Health increase	Pass
Damage Test	Health reduction	Pass
Death Test	Health below zero	Pass
Health Limit	Overflow detection	Fail

# The failing test highlights a gameplay edge case.

Code Coverage

Generated using:

Coverlet

ReportGenerator

Run:

dotnet test --collect:"XPlat Code Coverage"


HTML report available in:

coveragereport/index.html

Tech Stack

ASP.NET Core Web API

xUnit

FluentAssertions

Coverlet

ReportGenerator

Purpose

Demonstrates how automation frameworks validate gameplay behavior through RPC-style communication instead of direct logic invocation.
