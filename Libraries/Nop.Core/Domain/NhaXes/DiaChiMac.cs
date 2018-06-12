using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.NhaXes
{
    public class DiaChiMac : BaseEntity
    {
        public int Id { get; set; }
        public string DiaChiMacLine { get; set; }
        public string LineDienThoai { get; set; }
    }
}
