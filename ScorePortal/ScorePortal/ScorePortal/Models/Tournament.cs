 using System;
using System.Collections.Generic;
using System.Text;

namespace ScorePortal.Models
{
    public class Tournament
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ImageUrl { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
