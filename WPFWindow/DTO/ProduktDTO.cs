using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWindow.DTO
{
    public class ProduktDTO
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
