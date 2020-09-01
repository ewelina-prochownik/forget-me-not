using System.Collections;
using System.Collections.Generic;

namespace ForgetMeNot.DAL.Model
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int WateringFrequencyInDays { get; set; }
        public string NeededWaterAmount { get; set; }
        public int FertilizingFrequencyInDays { get; set; }
        public string NeededFertilizerAmount { get; set; }
        public string Description { get; set; }
        public string Insolation { get; set; }
        public string Base64Picture { get; set; }
        
        //relationships
        public virtual ICollection<Chore> Chores { get; set; }
        public virtual ICollection<CompletedChore> CompletedChores { get; set; }
    }
}