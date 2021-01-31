using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PeerSupport.Models
{
    public class Movie
    {
        public int ID { get; set; }

       public string Name { get; set; }

       [DataType(DataType.Date)]
       public DateTime Workweek { get; set; }

      public int Hours { get; set; }
        public int Minutes { get; set; }

        [DataType(DataType.MultilineText)]
     public string Notes { get; set; }
    }
}
