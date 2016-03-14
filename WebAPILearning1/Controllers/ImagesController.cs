using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPILearning1.Models;
using System.Web.Mvc;

namespace WebAPILearning1.Controllers
{
    public class ImagesController : ApiController
    {
        /// <summary>
        ///  http://localhost:7745/api/images
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ImageInfo> GetAllimages()
        {
            var imageDatabase = new ImageDatabase();
            return imageDatabase.GetAllInformation();
        }
        /// <summary>
        /// http://localhost:7745/api/images/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ImageInfo GetImages(int id)
        { 
            
            var imageDatabase = new ImageDatabase();
            var obj = new ImageInfo();
            var result = imageDatabase.GetAllInformation().Where(x => x.Machine.MachineId == id).FirstOrDefault();
            obj = result;
            return obj;

        
        }




    }
}
