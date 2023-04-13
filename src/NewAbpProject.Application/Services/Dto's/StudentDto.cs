using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Dto_s
{
    public class StudentDto : EntityDto<Guid>
    {
        public string StudentNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid? courseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int academicYear { get; set; }
    }
}
