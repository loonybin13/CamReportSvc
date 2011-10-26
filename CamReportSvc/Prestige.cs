using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamReportSvc
{
    public enum PrestigeType
    {
        General,
        Regional,
        National
    }

    public enum PrestigeCategory
    {
        Administration,
        CommunityService
    }
    public class Prestige
    {
        public string Description { get; set; }
        public int Amount{get;set;}
        public PrestigeCategory Category { get; set; }
        public PrestigeType Type { get; set; }
    }
}