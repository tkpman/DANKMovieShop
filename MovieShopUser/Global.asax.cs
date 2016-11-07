﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MovieShopUser
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //AutoMapper configuration begin.
            AutoMapper.Mapper.Initialize(config =>
            {
                config
                    .CreateMap
                    <Entities.Customer, MovieShopUser.Models.Checkout.CheckoutProcessViewModel>();
                config
                    .CreateMap
                    <Entities.Address, MovieShopUser.Models.Checkout.CheckoutProcessViewModel>();
                config
                    .CreateMap
                    <MovieShopUser.Models.Checkout.CheckoutProcessViewModel, Entities.Customer>();
                config
                    .CreateMap
                    <MovieShopUser.Models.Checkout.CheckoutProcessViewModel, Entities.Address>();
            });
            //AutoMapper configuration end.
        }
    }
}
