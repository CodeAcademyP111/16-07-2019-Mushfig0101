using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Task
{
   public class Medicine
    {
        private static int _id;
        public int ID { get; private set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }

        public Medicine()
        {
            _id++;
            ID = _id;
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Type} {Price}";
        }
    }



}
