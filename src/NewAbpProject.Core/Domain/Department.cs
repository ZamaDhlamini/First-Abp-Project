using Abp.Domain.Entities.Auditing;
using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.Department")]
    public class Department : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
    }
}
