using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class RoleAssignSendModel
    {
        public List<RoleAssignListModel> Roles { get; set; }
        public int UserId { get; set; }

    }
}
