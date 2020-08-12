using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TekzenApiClient.Models
{
    public class OrderModel
    {
        public SiparisResponseModel[] SiparisResponse { get; set; }
        public bool Basarili { get; set; }
        public string Mesaj { get; set; }
    }
}
