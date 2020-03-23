using System;
using System.Collections.Generic;
using System.Text;

namespace ITMWebUI.Library.Models.OEE
{
    public class DisponibilityModel
    {
        public int Id { get; set; }
        public bool Disponible { get; set; }
        public int Operation { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
