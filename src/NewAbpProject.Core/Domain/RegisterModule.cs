using Abp.Domain.Entities.Auditing;
using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.RegisterModule")]
    public class RegisterModule : FullAuditedEntity<Guid>
    {
        public virtual Student student { get; set; }
        ///<summary>
        ///
        /// </summary>

        public virtual Module Module { get; set; }

    }
}
