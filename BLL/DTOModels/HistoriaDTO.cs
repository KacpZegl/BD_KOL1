﻿using System;

namespace BLL.DTOModels
{
    public class HistoriaDTO
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IdGrupy { get; set; }
        public string TypAkcji { get; set; }
        public DateTime Data { get; set; } 
    }
}