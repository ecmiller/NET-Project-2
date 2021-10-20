using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_2.Domain
{
    public class UserPlan
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
