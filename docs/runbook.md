Runbook

Purpose
Operational guidance for local development and early deployments.

Local Setup
1) Ensure PostgreSQL is running and accessible.
2) Set connection strings in ScrumTeam.Server/appsettings.json and
   ScrumTeam.Server/appsettings.Development.json.
3) Run the server:
   dotnet run --project ScrumTeam.Server

Key Endpoints
- GET /api/teams/{id}
- POST /api/teams

Tenant Header
- Use X-Tenant-Id to scope requests to a tenant.
- If omitted, the default tenant id is used.

Health Checks (Development)
- /health for readiness
- /alive for liveness

Common Operations
- Run tests:
  dotnet test
- Restore:
  dotnet restore

Troubleshooting
- Connection issues: verify PostgreSQL host, port, database, and user.
- 404 endpoints: confirm Wolverine endpoints are registered.
- Tenant data missing: ensure X-Tenant-Id is set and matches stored data.
