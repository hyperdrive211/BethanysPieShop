﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Model
{
     public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get;  }
        IEnumerable<Pie> PiesOfTheWeek { get;  }
        Pie GetPieById(int pieId); 
    }
}
