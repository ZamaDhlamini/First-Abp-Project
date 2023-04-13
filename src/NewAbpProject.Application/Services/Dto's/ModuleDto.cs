using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NewAbpProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Dto_s
{
    [AutoMap(typeof(Module))]
    public class ModuleDto : EntityDto<Guid>
    {
        public Guid? CurseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

    }
}
