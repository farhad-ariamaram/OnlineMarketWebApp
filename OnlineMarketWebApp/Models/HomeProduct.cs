using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineMarketWebApp.Models
{
    public partial class HomeProduct
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long Lprice { get; set; }
        public string Image { get; set; }
    }
}
