﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Infrastructure.Services.Identity.Auth
{
    public class RedisOptions
    {
        public string ConnectionString { get; set; }
        public string Instance { get; set; }
    }
}
