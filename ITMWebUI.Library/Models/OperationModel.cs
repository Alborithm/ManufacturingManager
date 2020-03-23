using ITMWebUI.Library.Models.OEE;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMWebUI.Library.Models
{
    public class OperationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Line { get; set; }
        public DisponibilityModel Disponibility { get; set; }
    }
}
