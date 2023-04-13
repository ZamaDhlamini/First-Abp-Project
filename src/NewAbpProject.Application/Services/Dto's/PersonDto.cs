using Abp.Application.Services.Dto;
using NewAbpProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Services.Dto_s
{
    public class PersonDto : EntityDto<Guid>
    {
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RefListGender Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IdentificationNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CellPhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
    }
}
