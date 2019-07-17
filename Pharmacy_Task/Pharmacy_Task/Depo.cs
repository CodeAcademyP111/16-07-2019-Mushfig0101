using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Task
{
    public class Depo
    {
        private static int _id;
        public int ID { get; private set; }
        public string Name { get; set; }
        private List<Medicine> medicines;

        public Depo(string name)
        {
            _id++;
            ID = _id;
            Name = name;

            medicines = new List<Medicine>() {
                new Medicine{ Name = "Analglin",Type = "Basagri", Price = "2.85" },
                new Medicine{ Name = "Baralglin",Type = "Basagri", Price = "3" },
                new Medicine{ Name = "Maralglin",Type = "Qarinagri", Price = "4.15" },
                new Medicine{ Name = "Tetazol",Type = "Qarinagri", Price = "2.85" }
            };
        }
        public List<Medicine> GetMedicines()
        {
            return medicines;
        }

        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
        }

        public void DeleteMedicine(int id)
        {
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    medicines.RemoveAt(i);
                    return;
                }

            }
        }

        public Medicine ChosenMedicine(int id)
        {
            Medicine resoult = null;
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    resoult = medicines[i];
                }          
            }
            return resoult;
        }

        public void UpdateMedicine(int id, string name, string type, string price)
        {
            Medicine medicine = ChosenMedicine(id);
            medicine.Name = name;
            medicine.Type = type;
            medicine.Price = price;
        }
    }
}
