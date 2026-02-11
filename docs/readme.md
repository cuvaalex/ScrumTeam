ScrumTeam

Overview
ScrumTeam is a SaaS platform for managing Scrum teams efficiently. It
applies Jeff Sutherland's "Hyperproductive teams" guidance and the
PowerScrum scorecard model to help teams deliver faster and with better
predictability.

Key Capabilities
- Team and role management
- Backlog and sprint planning
- Flow visibility and WIP control
- Retrospectives with action tracking
- Metrics and hyperproductive indicators
- Integrations with Azure DevOps and JIRA

Architecture
- CQRS with Wolverine for API endpoints
- Marten on PostgreSQL for persistence
- Multi-tenant data model
- Domain modules under src/

Getting Started
1) Configure PostgreSQL connection strings in
   ScrumTeam.Server/appsettings.json.
2) Run the server:
   dotnet run --project ScrumTeam.Server
3) Optional: run tests
   dotnet test

Documentation
- Project vision: docs/features/VISION.md
- Feature docs: docs/features/
- Architecture: architecture.md
- Runbook: runbook.md

License
TBD
