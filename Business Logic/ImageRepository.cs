using MoresandTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoresandTest.Business_Logic
{
    public class ImageRepository: IImage
    {
        public ImageRepository()
        {

        }

        public void CreateImages(List<ImageDetails> imageDetails)
        {
            //Here You can save multiple Image Details
            throw new NotImplementedException();
        }
    }
}
