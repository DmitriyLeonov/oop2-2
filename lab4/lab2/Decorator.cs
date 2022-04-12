using lab4.Factory;
using lab4.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class PlaneDecorator:Plane
    {
        public PlaneDecorator(PlaneFactory factory):base(factory)
        {

        }
    }

    public class ExperimentalPlane : PlaneDecorator
    {
        public ExperimentalPlane(PlaneFactory factory) : base(factory)
        {
            
        }
        public ExperimentalPlane SetType(ExperimentalPlane plane)
        {
            plane.Type = "Экспериментальный";
            return plane;
        }
    }
}
