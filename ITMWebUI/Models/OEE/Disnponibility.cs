using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMWebUI.Models.OEE
{
    public class Disnponibility
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public bool Disponible { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
