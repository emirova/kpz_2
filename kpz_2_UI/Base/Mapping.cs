using AutoMapper;
using kpz_2_UI.ViewModels;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz_2_UI.Base
{
    internal class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<Order, OrderViewModel>();
            Mapper.CreateMap<OrderViewModel, Order>();

            Mapper.CreateMap<Edition, EditionViewModel>();
            Mapper.CreateMap<EditionViewModel, Edition>();

        }
    }
}
