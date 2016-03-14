using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPILearning1.Models
{
    public class ImageDatabase
    {





        public IEnumerable<ImageInfo> GetAllInformation()
        {
            var image = new List<ImageInfo>();
            image.Add(
                        new ImageInfo() {
                        ImageId = 1, ImageName = "Image1", ImageSource = "", ImageTop = 40,
                        ImageLeft = 20, Machine = new MacineryInfo() { MachineId=11, MachineName="A"} 
                                       }
                      );

            image.Add(
                        new ImageInfo()
                        {
                            ImageId = 2,
                            ImageName = "Image2",
                            ImageSource = "C:\\Users\\swapnil\\Pictures\\Me & My Hubby\\2707.jpg",
                            ImageTop = 40,
                            ImageLeft = 20,
                            Machine = new MacineryInfo() { MachineId = 22, MachineName = "B" }
                        }
                      );

            image.Add(
                        new ImageInfo()
                        {
                            ImageId = 3,
                            ImageName = "Image3",
                            ImageSource = "",
                            ImageTop = 40,
                            ImageLeft = 20,
                            Machine = new MacineryInfo() { MachineId = 33, MachineName = "C" }
                        }
                      );

            image.Add(
                        new ImageInfo()
                        {
                            ImageId = 4,
                            ImageName = "Image4",
                            ImageSource = "",
                            ImageTop = 40,
                            ImageLeft = 20,
                            Machine = new MacineryInfo() { MachineId = 44, MachineName = "D" }
                        }
                      );





            return image.ToList();
        
        
        
        }

    }
}