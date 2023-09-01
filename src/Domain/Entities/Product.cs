using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product:BaseAuditableEntity,ICommands
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        
        public int PropertyTypeId { get; set; }
        public int PropertyBrandId { get; set; }

        public string Description { get; set; }
        public bool IsAcctive { get; set; }
        public bool IsDelete { get; set; }
        public string Summary { get; set; }

        //Relations
        public ProductType ProductType { get; set; }
        public ProductBrand ProductBrand { get; set; }

    }
}
