using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ReproBug
{
	public class TestMiddleware
	{
		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly RequestDelegate _next;
		public TestMiddleware(
			IWebHostEnvironment webHostEnvironment,
			RequestDelegate next
		)
		{
			_webHostEnvironment = webHostEnvironment;
			_next = next;
			
			Console.WriteLine(_webHostEnvironment.WebRootPath);
		}

		public Task InvokeAsync(HttpContext httpContext)
		{
			return _next(httpContext);
		}
	}
}