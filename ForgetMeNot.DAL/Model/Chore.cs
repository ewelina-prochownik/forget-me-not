using System;
using System.Collections.Generic;

namespace ForgetMeNot.DAL.Model
{
    public class Chore
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public int IntervalInDays { get; set; }
        
        //relationships
        public int PlantId { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual IEnumerable<CompletedChore> CompletedChores { get; set; }
    }
}