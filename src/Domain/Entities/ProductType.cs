using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductType : BaseAuditableEntity, ICommands 
    {
        public string Title { get; set; }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAcctive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDelete { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Summary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
