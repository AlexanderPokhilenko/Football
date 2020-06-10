using BLL.Abstract;
using DAL.Abstract.Repositories;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL.Implementation
{
    public class TournamentService : ITournamentService
    {
        private readonly ITournamentRepository tournamentRep;
        private readonly IStageRepository stageRep;
        private readonly IStageTypeRepository stageTypeRep;

        public TournamentService(ITournamentRepository tournamentRep, IStageRepository stageRep, IStageTypeRepository stageTypeRep)
        {
            this.tournamentRep = tournamentRep;
            this.stageRep = stageRep;
            this.stageTypeRep = stageTypeRep;
        }

        public void AddParticipation(int tournamentId, ParticipationDto p)
        {
            throw new NotImplementedException();
        }

        public TournamentDto GetTournament(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TourPreviewDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
