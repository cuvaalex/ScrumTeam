Development Guide

Purpose
This guide defines how development work should proceed for this project.

Workflow
- Features are split into smaller user stories that can be prioritized and
  managed effectively.
- Implement user stories systematically:
  1) ATDD (Acceptance Test-Driven Development)
  2) TDD
  3) Implement only enough code to make tests pass
  4) Refactor the code
- Apply DDD principles to keep the code maintainable, scalable, and easy
  to understand.

Codex Usage Checklist
- Start from a user story and acceptance criteria before changing code.
- Write or update acceptance tests first, then unit tests.
- Implement the minimum code needed to pass tests.
- Refactor for clarity and cohesion after tests are green.
- Ask for a review focused on maintainability, scalability, and clarity.

Maintainability Standards
- Keep domain logic in the domain layer; avoid leaking infrastructure
  concerns into the core model.
- Prefer small, single-purpose functions and explicit types.
- Use clear, consistent naming; rename for clarity when needed.
- Avoid duplication; extract shared concepts into domain services or
  value objects.
- Document non-obvious decisions with short design notes or ADRs.

Scalability Standards
- Keep dependencies directional (domain -> application -> infrastructure).
- Favor interfaces and adapters for integrations (Azure DevOps, JIRA, etc.).
- Define bounded contexts and explicit integration seams.
- Add performance tests or benchmarks for known hotspots.

Readability Standards
- Keep modules cohesive and files focused on one responsibility.
- Limit branching depth; prefer early returns and guard clauses.
- Add brief comments only for non-obvious intent or tradeoffs.

Review Gates
- No untested change.
- No unclear naming or leaky abstractions.
- No mixing infrastructure and domain rules in the same module.

Architecture Notes
- Use CQRS with Wolverine for the API and Marten for persistence.
- Queries use IQuerySession, commands use IDocumentSession.
- Marten is configured for multi-tenant support; tenant id comes from
  the request header.
- Each domain lives in its own project under src (e.g. src/ScrumTeam.Teams).
- The server composes domain projects and hosts Wolverine endpoints.
- Tests are split by type under test/:
  - Unit tests: test/ScrumTeam.UnitTests
  - Integration tests: test/ScrumTeam.IntegrationTests
  - System tests: test/ScrumTeam.SystemTests
