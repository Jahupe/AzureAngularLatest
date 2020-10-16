using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevOpsAngular.Api.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
