using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sdc1_knowledge_check_2;

namespace sdc1_knowledge_check_2.Class
{
    public class Orders
    {
        public string? Name { get; set; }
        public int PartNumber { get; set; }
        public int Quantity { get; set; }
        public string? DayofWeek { get; set; }
        public string? Trial { get; set; }

        public override string ToString()
        {
            return $"Customer Name: {Name}, Part Number: {PartNumber}, Quantity: {Quantity}, Day to Ship: {DayofWeek}, Trial: {Trial}";
        }
    }
}
