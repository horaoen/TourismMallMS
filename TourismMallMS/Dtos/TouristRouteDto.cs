﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourismMallMS.Dtos
{
    public class TouristRouteDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }
        public double? Rating { get; set; }
        public DateTime? UptateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string TravelDays { get; set; }
        public string TripType { get; set; }
        public string DepartureCity { get; set; }
        public ICollection<TouristRoutePictureDto> TouristRoutePictures { get; set; }
    }
}