﻿using SignalRChat.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class GifController : Controller
    {
        public PartialViewResult Selector(string keywords,int offset = 0,int limit=5)
        {
            return PartialView("_GifSelector", GiphyAPIHandler.GifListFilter(keywords, limit, offset).data);
        }

        public PartialViewResult DisplayGif(string username,string keywords)
        {

            return PartialView("_GifDisplayer");
        }
    }
}