using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Models
{
    public class GetAllModelResponse
    {
        public int Id { get; set; }//1
        public Guid BrandId { get; set; } //1 
        public string BrandName { get; set; }
        public string Name { get; set; } // A8
    }
}
