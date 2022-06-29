using MoresandTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoresandTest.Business_Logic
{
    public interface IImage
    {
        void CreateImages(List<ImageDetails> imageDetails);
    }
}
