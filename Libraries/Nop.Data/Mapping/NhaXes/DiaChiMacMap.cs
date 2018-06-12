using Nop.Core.Domain.NhaXes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Data.Mapping.NhaXes
{
    public class DiaChiMacMap : NopEntityTypeConfiguration<DiaChiMac>
    {
        public DiaChiMacMap()
        {
            this.ToTable("CV_DiaChiMac");
            this.HasKey(c => c.Id);
        }
    }
}
