using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineMarketWebApp.Models
{
    public partial class Banner
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
    }
}
