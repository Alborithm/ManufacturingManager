using ITMWebUI.Models.OEE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMWebUI.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Line { get; set; }
        public Disnponibility Disponibility { get; set; }
        // Temporal use, to be deleted
        //public OpStatus Status { get; set; }

        //public class OpStatus
        //{
        //    public bool Power { get; set; }
        //    public bool Running { get; set; }
        //    public float Uptime { get; set; }
        //    public float Speed { get; set; }
        //    public float Quality { get; set; }
        //    public string DisplayStatus { get; set; }
        //}
    }
}
