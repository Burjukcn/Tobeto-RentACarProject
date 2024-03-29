﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Brand : BaseEntity<Guid>
    {
        public string Name { get; set; }  //Audi 


        public ICollection<Model> Models { get; set; }

        public Brand()
        {
            Models = new HashSet<Model>();
        }

        public Brand(Guid id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}