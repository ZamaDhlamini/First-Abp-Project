using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.Course")]
    public class Course : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Department? Department { get; set; }
    }
}
