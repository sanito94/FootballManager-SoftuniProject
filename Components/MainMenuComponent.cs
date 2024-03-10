using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Components
{
    public class MainMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("MainMenu"));
        }
    }
}
