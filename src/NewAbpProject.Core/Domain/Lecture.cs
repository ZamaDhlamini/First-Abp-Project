using NewAbpProject.Domain.Antributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    [Entity(TypeshortAlias = "Arf.lecture")]
    [DiscriminatorValue("Arf.Lecture")]
    public class Lecture : Person
    {
        public virtual string EmployeeId { get; set; }
        ///<summary>
        ///
        /// </summary>

        public virtual string Qualification { get; set; }
    }
}
