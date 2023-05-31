using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectMistakes.Data.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Modeli { get; set; }
        public int Narxi { get; set; }
        public int Yili { get; set; }
        public string Rangi { get; set; }

        public Autosalon Autosalon { get; set; }

        public IList<Mijoz> Mijoz { get; set; }
        public Car()
        {
            Mijoz = new List<Mijoz>();
        }
    }
}
