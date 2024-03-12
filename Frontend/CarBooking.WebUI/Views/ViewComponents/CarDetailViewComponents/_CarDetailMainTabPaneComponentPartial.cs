using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Views.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailMainTabPaneComponentPartial:ViewComponent
	{
		
		public async Task<IViewComponentResult> InvokeAsync()
		{
			
			return View();
		}
	}
}
