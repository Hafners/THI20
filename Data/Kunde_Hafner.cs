﻿namespace Data
{
    public class Kunde_Hafner
    { 
        public int Id { get; set; } = 0;

        public int UserId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal SalesVolume { get; set; }
    }
}
