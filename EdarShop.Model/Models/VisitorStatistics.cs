﻿using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EdarShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistics
    {
        [Key]
        public Guid ID { get; set; }

        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}
