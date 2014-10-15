using BookMarkApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMarkApp.Web.Models
{
	public class CategoryVM
	{
		public Category Category { get; set; }
		public Content Content { get; set; }
	}
}