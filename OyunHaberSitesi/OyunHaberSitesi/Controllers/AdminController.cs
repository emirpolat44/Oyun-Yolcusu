using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using OyunHaberSitesi.Model;


namespace OyunHaberSitesi.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        NewManager nm = new NewManager(new EFNewDAL());

        private readonly WeatherService _weatherService;
        private readonly ExchangeRateService _exchangeRateService;

        public AdminController()
        {
            _weatherService = new WeatherService();
            _exchangeRateService = new ExchangeRateService();
        }

        //public ActionResult Index()
        //{
        //    _weatherService = new WeatherService();
        //    return View();
        //}
        public async Task<ActionResult> Index()
        {
            var weather = await _weatherService.GetWeatherAsync("Istanbul");
            var exchangeRates = await _exchangeRateService.GetExchangeRatesAsync();
            var model = new WeatherAndRatesViewModel
            {
                Weather = weather,
                ExchangeRates = exchangeRates
            };
            return View(model);
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetById(id);
            return RedirectToAction("GetCategoryList");
        }

        public ActionResult GetNewList()
        {
            var newvalues = nm.GetList();
            return View(newvalues);
        }
        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(New p)
        {
            NewValidator newValidator = new NewValidator();
            ValidationResult results = newValidator.Validate(p);
            if (results.IsValid)
            {
                nm.NewAdd(p);
                return RedirectToAction("GetNewList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}
