using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PharmacyApp.Server.Models;

namespace PharmacyApp.Server.App.Models
{
    public class NomenclatureInput
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ValidationRegex { get; set; }
        public string Length { get; set; }
        public NomenclatureInputType Type { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}