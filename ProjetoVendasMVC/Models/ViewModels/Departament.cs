﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendasMVC.Models.ViewModels
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Departament() { }
    }
}