using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P6_CustomEnumerator
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        // Fill with some Car objects upon startup.
        public Garage()
        {
            carArray[0] = new Car("Cultus", 30);
            carArray[1] = new Car("Corolla", 55);
            carArray[2] = new Car("Civic", 30);
            carArray[3] = new Car("Mira", 30);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
