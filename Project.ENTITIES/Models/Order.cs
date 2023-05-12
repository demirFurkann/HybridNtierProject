using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity,IEntity
    {
        public string ShippingAddress { get; set; }

        //Relational Properties
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
