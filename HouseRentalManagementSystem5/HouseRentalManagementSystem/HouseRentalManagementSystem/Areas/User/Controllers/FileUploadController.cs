using HouseRentalManagementSystem.IRepository;
using HouseRentalManagementSystem.UserViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace HouseRentalManagementSystem.Areas.User.Controllers
{
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IApartmentRepository iApartmentRepository;
        private readonly IBuildingRepository iBuildingRepository;
        private readonly IWebHostEnvironment iWebHostEnvironment;
        private readonly IApartmentImageRepository iApartmentImageRepository;
        public FileUploadController(IBuildingRepository _iBuildingRepository, IWebHostEnvironment _iWebHostEnvironment, IApartmentImageRepository _iApartmentImageRepository, IApartmentRepository _iApartmentRepository)
        {
            iWebHostEnvironment = _iWebHostEnvironment;
            iApartmentImageRepository = _iApartmentImageRepository;
            iApartmentRepository = _iApartmentRepository;
            iBuildingRepository = _iBuildingRepository;
        }
        [Route("User/FileUpload/ApartmentBuildingImageUpload")]
        [HttpPost]
        public IActionResult ApartmentBuildingImageUpload(int id)
        {
            IFormFile photo = null;
            string uniqueImageName = null;
            var files = HttpContext.Request.Form.Files;
            foreach (IFormFile Photo in HttpContext.Request.Form.Files)
            {
                photo = Photo;
            }
            ApartmentBuildingViewModel obj = iBuildingRepository.GetById(id);
            if (photo != null)
            {
                string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "images/building_images");
                uniqueImageName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueImageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                photo.CopyTo(fileStream);
                fileStream.Close();
                obj.ImageName = uniqueImageName;
                iBuildingRepository.Update(obj);
            }
            var building = iBuildingRepository.GetAll();
            return Ok(building);
        }
        [Route("/User/FileUpload/ApartmentImageUpload")]
        [HttpPost]
        public IActionResult ApartmentImageUpload(int id)
        {
            string uniqueImageName = null;
            var files = HttpContext.Request.Form.Files;
            //foreach (IFormFile photo in HttpContext.Request.Form.Files)
            //{
            //    Photo = photo;
            //}
            ApartmentImageViewModel imageObj = new ApartmentImageViewModel();
            if (files != null && files.Count > 0)
            {
                foreach (IFormFile photo in files)
                {
                    string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "images/apartment_images");
                    uniqueImageName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueImageName);
                    FileStream fileStream = new FileStream(filePath, FileMode.Create);
                    photo.CopyTo(fileStream);
                    fileStream.Close();
                    imageObj.AptId = id;
                    imageObj.ImageName = uniqueImageName;
                    iApartmentImageRepository.Insert(imageObj);
                }
            }
            //if (Photo != null)
            //{
            //    string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "images/building_images");
            //    uniqueImageName = Photo.FileName;
            //    string filePath = Path.Combine(uploadFolder, uniqueImageName);
            //    FileStream fileStream = new FileStream(filePath, FileMode.Create);
            //    Photo.CopyTo(fileStream);
            //    fileStream.Close();
            //}
            ////Create the Directory.
            //string path = HttpContext.Current.Server.MapPath("~/Uploads/");
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            ////Save the Files.
            //foreach (string key in HttpContext.Current.Request.Files)
            //{
            //    HttpPostedFile postedFile = HttpContext.Current.Request.Files[key];
            //    postedFile.SaveAs(path + postedFile.FileName);
            //}

            //Send OK Response to Client.

            var apartment = iApartmentRepository.GetAll();
            return Ok(apartment);
        }
    }
}
