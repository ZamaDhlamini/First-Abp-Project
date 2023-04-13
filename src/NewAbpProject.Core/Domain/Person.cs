using Abp.Domain.Entities.Auditing;
using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.Person")]
    [Table("Arf_Persons")]
    [DiscriminatorValue("Arf.Person")]
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public virtual string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public virtual DateTime? DateofBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>

        ///public virtual RefListGender Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public virtual string IdentificationNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public virtual string CellPhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary> 
        public virtual string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>

    }
}
