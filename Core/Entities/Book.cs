using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book : BaseEntity
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public required string ISBN { get; set; }
        public required string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public required string Language { get; set; }
        public int PageCount { get; set; }
    }
}
