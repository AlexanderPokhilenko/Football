using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Stage
    {
        [Key, Required]
        public int Id { get; set; }
        [ForeignKey("StageTypeId")]
        public int StageTypeId { get; set; }
        [ForeignKey("StageTypeId")]
        public StageType StageType { get; set; }
        [ForeignKey("TournamentId")]
        public int TournamentId { get; set; }
        [ForeignKey("TournamentId")]
        public Tournament Tournament { get; set; }
        [ForeignKey("TeamId")]
        public int FirstTeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team FirstTeam { get; set; }
        [ForeignKey("TeamId")]
        public int SecondTeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team SecondTeam { get; set; }
        [Required]
        public byte FirstTeamPoints { get; set; }
        [Required]
        public byte SecondTeamPoints { get; set; }
    }
}