﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CarImage : BaseEntity<Guid>
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; }


        public virtual Car Car { get; set; }

        public CarImage()
        {

        }

        public CarImage(Guid id, int carId, string imagePath) : this()
        {
            Id = id;
            CarId = carId;
            ImagePath = imagePath;
        }
    }
}