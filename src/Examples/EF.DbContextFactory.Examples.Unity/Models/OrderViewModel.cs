﻿using System;

namespace EF.DbContextFactory.Examples.Unity.Models
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public bool Selected { get; set; }
    }
}