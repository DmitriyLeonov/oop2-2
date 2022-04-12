using lab4.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class MementoPlaneList
    {
        public List<Plane> planes = new List<Plane>();
        public MementoPlaneList(List<Plane> state)
        {
            if(state != null)
            {
                foreach(Plane plane in state)
                {
                    this.planes.Add(plane);
                }
            }
            else if(state == null)
                this.planes.Clear();
        }

    }

    public class CaretakerPlanes
    {
        public Stack<MementoPlaneList> History { get; private set; }
        public CaretakerPlanes()
        {
            History = new Stack<MementoPlaneList>();
        }
    }
}
