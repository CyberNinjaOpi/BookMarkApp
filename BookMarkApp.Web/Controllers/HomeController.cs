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
	public class HomeController : Controller
	{
		IBookMarkAppAdapter _adapter;
		public HomeController() {
			_adapter = new BookMarkAppAdapter();
		}
		public HomeController(IBookMarkAppAdapter adapter) {
			_adapter = adapter;
		}
		public ActionResult Index()
		{
			List<Category> category = _adapter.GetAllCategory();
			return View(category);
		}

		//public ActionResult About()
		//{
		//	ViewBag.Message = "Your application description page.";

		//	return View();
		//}

		//public ActionResult Contact()
		//{
		//	ViewBag.Message = "Your contact page.";

		//	return View();
		//}
	}
}