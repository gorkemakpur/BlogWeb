using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
	{
	
		WriterManager _writerManager = new WriterManager(new EfWriterRepository());
		CityManager _cityManager =new CityManager(new EfCityRepository());

		[HttpGet]
		public IActionResult Index()
		{
			List<SelectListItem> valueCity = (from x in _cityManager.GetList()
											  select new SelectListItem
											  {
												  Text = x.CityName,
												  Value = x.CityID.ToString()
											  }).ToList();
			ViewBag.ValueCity = valueCity;
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidatior wv = new WriterValidatior();
			ValidationResult results = wv.Validate(writer);

			if (results.IsValid)
			{
				writer.WriterStatus = true;
				writer.WriterAbout = "Hakkımızda test";
				_writerManager.AddWriter(writer);
				return RedirectToAction("Index");
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
