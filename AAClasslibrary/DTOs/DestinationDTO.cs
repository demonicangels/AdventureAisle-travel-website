﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DestinationDTO
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string BriefDescription { get; set; }
        public double AvgRating { get; set; }
        public string Currency { get; set; }
        public string Climate { get; set; }

        public string ImgURL { get; set; }

        public string DesInfo()
        {
            return $"City: {Name}, Country: {Country}, History: {BriefDescription}";
        }

    }
}