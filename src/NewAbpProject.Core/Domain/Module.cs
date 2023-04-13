using Abp.Domain.Entities.Auditing;
using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.Module")]

    public class Module : FullAuditedEntity<Guid>
    {
        //This is a foreign key linking with the course the module follows
        public virtual Course Course { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Code { get; set; }
    }
}
