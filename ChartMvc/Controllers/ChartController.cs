﻿using Microsoft.AspNetCore.Mvc;
using ChartMvc.Models;

namespace ChartMvc.Controllers
{
    public class ChartController : Controller
    {
        public ActionResult LineTemperatureDate()
        {
            string[] Months = { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
            ViewBag.MonthsLabel = Months;
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

            return View(Locations);
        }
        public ActionResult BarTravelData()
        {
            string[] countries = { "美國", "日本", "泰國", "琉球", "紐西蘭", "澳洲" };
            int [] votes = { 8, 22, 13, 15, 17, 21 };
            ViewBag.Countries = countries;
            ViewBag.Votes = votes;
            return View();
        }

        public ActionResult RadarCarData() 
        {
            string[] scoperLables = { "新潮", "價格", "維修", "性能", "油耗", "配備" };
            int[] suvScores = { 90, 70, 80, 88, 50, 65 };
            int[] sedanScores = { 64, 83, 85, 76, 93, 58 };

            ViewBag.ScopeLabels = scoperLables;
            ViewBag.SuvScores = suvScores;
            ViewBag.sedanScores = sedanScores;

            return View();
        }

        public ActionResult PieSalesData()
        {
            string[] productLabels = { "3C", "food", "服飾", "保養品", "鞋子", "家電"};
            double[] productData = { 39.1, 8.7, 15, 14, 8, 15.2 };
            string[] countryLabel = { "中國", "日本", "韓國", "越南", "泰國", "新加坡" };
            double[] countryData = { 45, 11, 14, 8, 10, 12 };

            ViewBag.ProductLabels = productLabels;
            ViewBag.ProductData = productData;
            ViewBag.CountryLabel = countryLabel;
            ViewBag.CountryData = countryData;

            return View();
        }
    }
}
