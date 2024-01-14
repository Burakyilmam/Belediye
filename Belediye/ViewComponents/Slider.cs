using Business.Abstract;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace Belediye.Areas.Homepage.ViewComponents
{
    public class Slider : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public Slider(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.List();
            return View(sliders);
        }
    }
}
