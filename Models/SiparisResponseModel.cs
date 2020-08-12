using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TekzenApiClient.Models
{
    public class SiparisResponseModel
    {
        public int BelgeId;
        public string BelgeNo;
        public int BelgeMekanId;
        public DateTime BelgeTarih;
        public DateTime BelgeSevkTarih;
        public DateTime BelgeVadeTarih;
        public Enum BelgeTip;
        public Enum BelgeDurum;
        public string BelgeNotu;
        public BelgeSatirlariModel[] BelgeSatirlari;
    }
}
