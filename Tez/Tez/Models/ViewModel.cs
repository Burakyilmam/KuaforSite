using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tez.Models
{
    public class ViewModel
    {
        public IEnumerable<MüşteriModel> Müşteri { get; set; }
        public IEnumerable<YöneticiModel> Yönetici { get; set; }
    }
}