using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class BnrAppConfig
    {
        public Guid BnrAppconfigId { get; set; }
        public string ConfigJson { get; set; }
        public string ConfigType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
