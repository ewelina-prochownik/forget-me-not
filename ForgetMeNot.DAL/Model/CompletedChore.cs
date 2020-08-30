using System;

namespace ForgetMeNot.DAL.Model
{
    public class CompletedChore
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        
        //relationships
        public int PlantId { get; set; }
        public virtual Plant Plant { get; set; }
        public int ChoreId { get; set; }
        public virtual Chore Chore { get; set; }
    }
}