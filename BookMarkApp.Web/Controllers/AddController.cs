using BookMarkApp.DataModels;
using BookMarkApp.Db.Adapters.Data;
using BookMarkApp.Db.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMarkApp.Web.Controllers
{
	public class AddController : Controller
	{
		IBookMarkAppAdapter _adapter;
		public AddController()
		{
			_adapter = new BookMarkAppAdapter();
		}
		public AddController(IBookMarkAppAdapter adapter)
		{
			_adapter = adapter;
		}
		[HttpGet]
		public ActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddCategory(string title)
		{
			Category category = new Category();
			category.Title = title;
			category = _adapter.AddCategory(category);
			return Redirect("/Home/Index");
		}
	}
}