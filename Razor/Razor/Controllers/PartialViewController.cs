using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SimpCard()
        {
            return View();
        }

        public ActionResult ManCard()
        {
            List<Card> cards = new List<Card>
            {
                new Card{Name = "Ninomae Ina'nis", Brief="是一名VTuber、歌手和插畫家", Photo="inayuyu.jpg", WikiUrl="https://zh.wikipedia.org/zh-tw/%E4%B8%80%E4%BC%8A%E9%82%A3%E5%B0%94%E6%A0%96"},
                new Card{Name = "Gawr Gura", Brief="A!", Photo="Gura.png", WikiUrl="https://zh.wikipedia.org/zh-tw/%E5%99%B6%E5%97%9A%C2%B7%E5%8F%A4%E6%8B%89"},
                new Card{Name = "Calli", Brief="是英語虛擬YouTuber、饒舌歌手，為hololive的成員", Photo="Calli.jpg", WikiUrl = "https://zh.wikipedia.org/zh-tw/%E6%A3%AE%E7%BE%8E%E8%81%B2"},
                new Card{Name = "Watson Amelia", Brief="一位私家偵探和時間旅行者", Photo="AME.jpg", WikiUrl="https://zh.wikipedia.org/zh-tw/%E8%8F%AF%E7%94%9F%C2%B7%E8%89%BE%E7%B1%B3%E8%8E%89%E4%BA%9E"},
                new Card{Name = "Kiara", Brief="是一隻可以死後重生的鳳凰，變身為人形", Photo="Kiara.png", WikiUrl="https://zh.wikipedia.org/zh-tw/%E5%B0%8F%E9%B8%9F%E6%B8%B8%E7%90%AA%E4%BA%9A%E6%8B%89"},
                new Card{Name = "Yoshika", Brief="歌えるさつまいもアイドルを目指す個人勢VTuber", Photo="Yoshika.jpg", WikiUrl="https://www.youtube.com/@YOSHIKA-Ch"}
            };
            return View(cards);
        }
    }
}