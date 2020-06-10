using System.Collections.Generic;

namespace DTO
{
    public class TourPreviewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<TeamDto> Teams { get; set; }
    }
}