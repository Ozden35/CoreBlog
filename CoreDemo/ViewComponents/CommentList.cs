using Azure.Identity;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					  Username = "Eğlaz"
				},
				   new UserComment
				  {
					ID=2,
					Username="Yaprak"
				  },
					new UserComment
				  {
					ID=3,
					Username="Sunay"
				  }
			 };
			return View(commentvalues);
		}
	}
}
