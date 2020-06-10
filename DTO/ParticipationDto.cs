namespace DTO
{
    public class ParticipationDto
    {
        public string StageTypeName { get; set; }
        public string TournamentName { get; set; }
        public string FirstTeamName { get; set; }
        public string SecondTeamName { get; set; }
        public byte FirstTeamPoints { get; set; }
        public byte SecondTeamPoints { get; set; }
    }
}