using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.Employee")]
    [DiscriminatorValue("Arf.Employee")]
    public class Employee : Person
    {
        public virtual string EmployeeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Department Department { get; set; }

    }
}
