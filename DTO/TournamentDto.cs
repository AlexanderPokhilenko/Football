using System.Collections.Generic;

namespace DTO
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ParticipationDto> Participations { get; set; }
    }
}