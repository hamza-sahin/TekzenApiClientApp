using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TekzenApiClient.Models
{
    public class MagazaModel
    {
        public MekanResponseModel[] MekanResponse { get; set; }
        public bool Basarili { get; set; }
        public string Mesaj { get; set; }
    }
}
