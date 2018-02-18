using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace seuWinDock.Models
{
    class TimePunche
    {
        private Guid _EmployeeID;
        private Guid _DepartmentID;
        private string _DepartmentName;
        private Guid _LocationID;
        private DateTime _DateWorked;
        private Boolean _IsClosed;
        private Guid _ID;
        private List<TimeInOut> _tpList;
        public Guid EmployeeID
        {
            get { return _EmployeeID; }
            protected set { _EmployeeID = value; }
        }
        public Guid DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            protected set
            {
                _DepartmentID = value;
            }
        }
        public string DepartmentName
        {
            get
            {
                return _DepartmentName;
            }
            protected set
            {
                _DepartmentName = value;
            }
        }
        public Guid LocationID
        {
            get
            {
                return _LocationID;
            }
            protected set
            {
                _LocationID = value;
            }
        }
        public DateTime DateWorked
        {
            get
            {
                return _DateWorked;
            }
            set
            {
                _DateWorked = value;
            }
        }
        public Boolean IsClosed
        {
            get
            {
                return _IsClosed;
            }
            set
            {
                _IsClosed = value;
            }
        }
        public Guid ID
        {
            get
            {
                return _ID;
            }
            protected set
            {
                _ID = value;
            }
        }
        public List<TimeInOut> tpList
        {
            get
            {
                return _tpList;
            }
            set
            {
                _tpList = value;
            }
        }
    }
    class TimeInOut
    {
        private Guid _TimepuncheID;
        private DateTime _TimeIn;
        private DateTime _TimeOut;
        private Guid _JobDescriptionID;
        private Decimal _HoursWorked;
        private String _Hours;
        private Boolean _isHourly;
        private Guid _ID;

        public Guid TimepuncheID
        {
            get
            {
                return _TimepuncheID;
            }
            set
            {
                _TimepuncheID = value;
            }
        }
        public DateTime TimeIn
        {
            get
            {
                return _TimeIn;
            }
            set
            {
                _TimeIn = value;
            }

        }
        public DateTime TimeOut
        {
            get
            {
                return _TimeOut;
            }
            set
            {
                _TimeOut = value;
            }

        }
        public Guid JobDescriptionID
        {
            get
            {
                return _JobDescriptionID;
            }
            set
            {
                _JobDescriptionID = value;
            }

        }
        public Decimal HoursWorked
        {
            get
            {
                return _HoursWorked;
            }
            set
            {
                _HoursWorked = value;
            }

        }
        public Boolean isHourly
        {
            get
            {
                return _isHourly;
            }
            set
            {
                _isHourly = value;
            }

        }
        public Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }

        }
    }

}
