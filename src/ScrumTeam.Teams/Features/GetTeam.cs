using Marten;
using Wolverine.Http;

namespace ScrumTeam.Teams.Features;


public static class GetTeamEndpoint
{
    [WolverineGet("/api/teams/{id:guid}")]
    public static Task<Team?> Handle(Guid id, IQuerySession session, CancellationToken cancellationToken)
    {
        return session.LoadAsync<Team>(id, cancellationToken);
    }
}
