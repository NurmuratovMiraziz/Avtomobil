using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectMistakes.Data.Model
{
    public class Mijoz
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Car> Cars { get; set; }
        public Mijoz()
        {
            Cars = new List<Car>();
        }
    }
}
