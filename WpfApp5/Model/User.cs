using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Core;
using WpfApp5.Model;
using WpfApp5.View;


namespace WpfApp5.Model
{
   public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
       public virtual Role Role { get; set; }
    }
}
