using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class SliderRepository : GenericRepository<Slider>, ISliderDal
    {
        public SliderRepository(DataContext context) : base(context)
        {
        }
    }
}
