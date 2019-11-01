using PracticeSystem.DAL;
using PracticeSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSystem.BAL
{
    [DataObject]
    public class StaffController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Staff> ListStaff()
        {
            using(var context = new PracticeContext())
            {
                return context.Staffs.ToList();
            }
        }
    }
}
