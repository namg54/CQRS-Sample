using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public interface ICommands
    {
        public string Description { get; set; }
        public bool IsAcctive { get; set; }
        public bool IsDelete { get; set; }
        public string Summary { get; set; }
    }
    public class Commands:ICommands
    {
        public string Description { get; set; }
        public bool IsAcctive { get; set; }
        public bool IsDelete { get; set; }
        public string Summary { get; set; }
    }
}
