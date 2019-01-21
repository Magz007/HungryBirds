using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Models
{
    public class Selections
    {
        public int Id { get; set; }
        public int MealsId { get; set; }
        public int StudentID { get; set; }
        public DateTime Date { get; set; }

    }
}
