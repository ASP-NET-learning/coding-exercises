﻿using Microsoft.AspNetCore.Mvc;
using MvcJson.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace MvcJson.Controllers
{
    public class JsonController : Controller
    {
        public ActionResult LineTemperatureJSON()
        {
            string[] Labels = { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
            string JsonLabels = JsonConvert.SerializeObject(Labels);
            ViewBag.Labels = JsonLabels;

            List<Location> Locations = new List<Location>
            {
                new Location
                {
                    City = "台北",
                    Temperature = new double[] {16.1, 16.5, 18.5, 21.9, 25.2, 27.7, 29.6, 29.2, 27.4, 24.5, 21.5, 17.9}
                },
                new Location
                {
                    City = "台中",
                    Temperature = new double[] {16.6, 17.3, 19.6, 23.1, 26.0, 27.6, 28.6, 28.3, 27.4, 25.2, 21.9, 18.1}
                },
                new Location
                {
                    City = "高雄",
                    Temperature = new double[] {19.3, 20.3, 22.6, 25.4, 27.5, 28.5 ,29.2, 28.7, 28.1, 26.7, 24.0, 20.6}
                }

            };

            string JsonLocations = JsonConvert.SerializeObject(Locations);
            ViewBag.JsonLocations = JsonLocations;
            return View(Locations);
        }

    }
}
