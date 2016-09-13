using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie1.Models
{
    public class MovieGenreViewModel
    {
		public List<Movie> movies;//电影列表
		public SelectList genre;//允许用户从列表中选择genre
		public string movieGenre { get; set; }//包含选中的genre
    }
}
