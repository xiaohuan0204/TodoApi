using MvcMovie1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie1.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceprovider)
		{
			using (var context = new ApplicationDbContext(serviceprovider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
			{
				if (context.Movie.Any())
				{
					return;
				}
				context.Movie.AddRange(
					new Movie
					{
						Title = "暴走大事件",
						ReleaseTime = DateTime.Parse("2016-05-21"),
						Genre = "Joy",
						Price = 23
					},
					new Movie
					{
						Title = "网易风云音乐",
						ReleaseTime = DateTime.Parse("2016-05-25"),
						Genre = "music",
						Price = 5600
					}
				);
				context.SaveChanges();
			}
		}
	}
}
