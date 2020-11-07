using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Info
    {
        public int LibID { get; set; }
        public int PersonType { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Nation { get; set; }
        public int CardType { get; set; }
        public string IdCard { get; set; }
        public string Birthday { get; set; }
        public string Telnum { get; set; }
        public string Native { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public int MjCardFrom { get; set; }
        public int MjCardNo { get; set; }
        public int Tempvalid { get; set; }
        public int CustomizeID { get; set; }
        public string PersonUUID { get; set; }
        public string EffectNumber { get; set; }
        public string ValidBegin { get; set; }
        public string ValidEnd { get; set; }
    }

    public class Root
    {
        public string @operator { get; set; }
        public Info info { get; set; }
        public string picinfo { get; set; }
    }


}
