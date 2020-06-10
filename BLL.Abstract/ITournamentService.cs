using DTO;
using System.Collections.Generic;

namespace BLL.Abstract
{
    public interface ITournamentService
    {
        void AddParticipation(int tournamentId, ParticipationDto p);
        TournamentDto GetTournament(int id);
        IEnumerable<TourPreviewDto> GetAll();
    }
}
