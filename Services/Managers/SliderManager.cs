using Business.Services;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider t)
        {
            _sliderDal.Add(t);
        }

        public void Delete(Slider t)
        {
           _sliderDal.Delete(t);
        }

        public Slider Get(int id)
        {
           return _sliderDal.Get(id);
        }

        public List<Slider> List()
        {
            return _sliderDal.List();
        }

        public void Update(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
