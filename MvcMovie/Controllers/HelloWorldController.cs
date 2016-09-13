using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
	public class HelloWorldController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
		//HtmlEncoder.Default.Encode 来保护应用程序免受恶意输入
		//public string Welcome(string name,int numTimes=1) {
		//	return HtmlEncoder.Default.Encode($"Hello {name},id：{numTimes}");
		//}
		public IActionResult Welcome(string name,int numTimes=1)
		{
			ViewData["Message"] = "Hello" + name;
			ViewData["NunTimes"] = numTimes;
			return View();
		}
	}
}
