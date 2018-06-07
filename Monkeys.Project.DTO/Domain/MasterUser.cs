using System;
using System.Text;
using System.Collections.Generic;

namespace Monkeys.Project.DTO
{
    public class MasterUser
    {
        public virtual int Userid { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int? Userstatus { get; set; }
        public virtual string Createdby { get; set; }
        public virtual DateTime? Createddate { get; set; }
        public virtual string Updatedby { get; set; }
        public virtual DateTime? Updateddate { get; set; }
    }
}
