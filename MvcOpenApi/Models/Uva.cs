using System.ComponentModel.DataAnnotations;

namespace MvcOpenApi.Models
{
    public class Rootobject
    {
        public Field[] fields { get; set; }
        public string resource_id { get; set; }
        public __Extras __extras { get; set; }
        public bool include_total { get; set; }
        public string total { get; set; }
        public string resource_format { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public _Links _links { get; set; }
        public Record[] records { get; set; }
    }

    public class __Extras
    {
        public string api_key { get; set; }
    }

    public class _Links
    {
        public string start { get; set; }
        public string next { get; set; }
    }

    public class Field
    {
        public string id { get; set; }
        public string type { get; set; }
        public Info info { get; set; }
    }

    public class Info
    {
        public string label { get; set; }
    }

    public class Record
    {
        [Display(Name = "測站名稱")]
        public string sitename { get; set; }
        [Display(Name = "紫外線指數")]
        public string uvi { get; set; }
        [Display(Name = "發布單位")]
        public string unit { get; set; }
        [Display(Name = "縣市")]
        public string county { get; set; }
        [Display(Name = "WGS84經度")]
        public string wgs84_lon { get; set; }
        [Display(Name = "WGS84緯度")]
        public string wgs84_lat { get; set; }
        [Display(Name = "資料發佈時間")]
        public string datacreationdate { get; set; }
    }


}
