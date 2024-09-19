using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soneta.Types;

namespace ApiOcrAruba.Models
{
    [BinSerializable]
    public class ZalacznikEmail
    {
        public int Id { get; set; }
        public string NazwaPliku { get; set; }
        public byte [] Plik { get; set; }
    }
}
