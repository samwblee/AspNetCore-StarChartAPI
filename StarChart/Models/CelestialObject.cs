using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models {
    public class CelestialObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OribtedObjectId { get; set; }
        [NotMapped]    
        public List<CelestialObject> Satellites { get; set; }
        public TimeSpan OribtalPeriod { get; set; }
    }
}

