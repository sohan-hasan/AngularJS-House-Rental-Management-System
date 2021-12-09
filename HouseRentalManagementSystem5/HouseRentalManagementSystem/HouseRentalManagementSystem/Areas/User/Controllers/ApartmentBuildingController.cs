using HouseRentalManagementSystem.IRepository;
using HouseRentalManagementSystem.UserViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using X.PagedList;

namespace HouseRentalManagementSystem.Controllers
{
    //[Authorize]
    public class ApartmentBuildingController : Controller
    {
        private readonly IBuildingRepository iBuildingRepository;
        private readonly IWebHostEnvironment iWebHostEnvironment;
        public ApartmentBuildingController(IBuildingRepository _iBuildingRepository, IWebHostEnvironment _iWebHostEnvironment)
        {
            iWebHostEnvironment = _iWebHostEnvironment;
            iBuildingRepository = _iBuildingRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Index(string SearchString, string CurrentFilter, string SortOrder, int? page)
        //{
        //    if(SearchString != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
        //        SearchString = CurrentFilter;
        //    }
        //    ViewBag.SortNameParam = string.IsNullOrEmpty(SortOrder) ? "name_desc" : "";
        //    ViewBag.CurrentFilter = SearchString;
        //    IEnumerable<ApartmentBuildingViewModel> itemList = iBuildingRepository.GetAll();
        //    int indexNumber = 0;
        //    foreach (var item in itemList)
        //    {
        //       item.SirialNumber = indexNumber += 1;

        //    }
        //    if(!string.IsNullOrEmpty(SearchString))
        //    {
        //        itemList = itemList.Where(e => e.BuildingShortName.ToUpper().Contains(SearchString.ToUpper())).ToList();
        //    }
        //    switch (SortOrder)
        //    {
        //        case "name_desc":
        //            itemList = itemList.OrderByDescending(e => e.SirialNumber).ToList();
        //            break;
        //        default:
        //            itemList = itemList.OrderBy(e => e.SirialNumber).ToList();
        //            break;
        //    }
        //    int pageSize = 5;
        //    int pageNumber = (page ?? 1);
        //    return View(itemList.ToPagedList(pageNumber, pageSize));
        //}
        [HttpGet]
        public JsonResult GetAll()
        {
            var buildings = iBuildingRepository.GetAll();
            return Json(buildings, new JsonSerializerOptions());

        }
        [HttpPost]
        public JsonResult Create([FromBody] ApartmentBuildingViewModel objModel)
        {
            ApartmentBuildingViewModel returnObj = new ApartmentBuildingViewModel();
            if (ModelState.IsValid)
            {
                returnObj = iBuildingRepository.Insert(objModel);
            }
            return Json(returnObj.BuildingId, new JsonSerializerOptions());
        }
        [HttpPost]
        public JsonResult Edit([FromBody] ApartmentBuildingViewModel objModel)
        {
            ApartmentBuildingViewModel returnObj = new ApartmentBuildingViewModel();
            if (ModelState.IsValid)
            {
                if (objModel.BuildingId > 0)
                {
                    returnObj = iBuildingRepository.Update(objModel);
                }
            }
            return Json(returnObj.BuildingId, new JsonSerializerOptions());
        }


        [HttpPost]
        public JsonResult Delete(int id)
        {
            iBuildingRepository.Delete(id);
            var data = iBuildingRepository.GetAll();
            return Json(data, new JsonSerializerOptions());
        }
    }
}
