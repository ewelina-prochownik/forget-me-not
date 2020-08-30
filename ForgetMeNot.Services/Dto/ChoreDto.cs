using System;

namespace ForgetMeNot.Services.Dto
{
    public class ChoreDto
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public int IntervalInDays { get; set; }
        public bool IsCompleted { get; set; }
        public int PlantId { get; set; }
    }
}