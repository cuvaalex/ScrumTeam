using Marten;
using Wolverine.Http;

namespace ScrumTeam.Teams.Features;

public record CreateTeam(string Name);

public record TeamCreated(Guid Id, string Name);


public static class CreateTeamEndpoint
{
    [WolverinePost("/api/teams")]
    public static CreationResponse<TeamCreated> Handle(CreateTeam command, IDocumentSession session)
    {
        var team = new Team(Guid.NewGuid(), command.Name);
        session.Store(team);

        return CreationResponse.For(new TeamCreated(team.Id, team.Name), $"/api/teams/{team.Id}");
    }
}
