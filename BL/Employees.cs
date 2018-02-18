using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seuWinDock.Models;

namespace seuWinDock.BL
{
    class Employees
    {
        public static List<Unloader> GetEmployees()
        {
            var EmpList = new List<Unloader>();
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "William Walklett" });
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "Randy Finster" });
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "Chris Spence" });
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "Paul Bradley" });
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "Bradley Buckley" });
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "Buck Davis" });
            EmpList.Add(new Unloader { EmployeeID = Guid.NewGuid(), EmployeeName = "Spencer Tracy" });
            return EmpList;
        }
    }
}
