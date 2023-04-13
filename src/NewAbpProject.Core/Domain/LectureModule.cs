using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbpProject.Domain
{
    public class LectureModule : FullAuditedEntity<Guid>
    {
        //This is a foreign key from table of lecture's
        public virtual Lecture Lecture { get; set; }
        ///<summary>
        ///
        /// </summary>
        ///  Foreign key from table of modules

        public virtual Lecture Module { get; set; }
    }
}
