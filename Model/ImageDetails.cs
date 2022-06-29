using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoresandTest.Model
{
    public class ImageDetails
    {
        public int Name { get; set; }
        public int Size { get; set; }
        public int Radius { get; set; }

        public List<ImageEffect> Effect { get; set; }

    }

    public class ImageEffect
    {
        public string Effect { get; set; }
    }
}
