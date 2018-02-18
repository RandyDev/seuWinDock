using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seuWinDock.Models
{
    public class Employee
    {
        private string _rtdsFirstName;
        private string _rtdsLastName;
        private string _Comments;
        private Guid _Certification;
        private List<Certification> _empCertifications;
        private byte[] _PhotoJpegData;
        private Guid _LocationID;
        private string _Login;
        private string _rtdsPassword;
        private bool _Locked;
        private int _AccessRightsMask;
        private Guid _ID;
        private Guid _rowguid;
        private Employment _Employment;
        private ssUser _ssUser;
        private string _LocationName;
        private Guid _HomeLocationID;
        private int _PayrollEmpNum;
        private DateTime _TermDate;

        public string rtdsFirstName
        {
            get { return _rtdsFirstName; }
            set { _rtdsFirstName = value; }
        }
        public string rtdsLastName
        {
            get { return _rtdsLastName; }
            set { _rtdsLastName = value; }
        }
        public string Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }
        public Guid Certification
        {
            get { return _Certification; }
            set { _Certification = value; }
        }
        public Guid LocationID
        {
            get { return _LocationID; }
            protected set { _LocationID = value; }
        }
        public Guid HomeLocationID
        {
            get { return HomeLocationID; }
            protected set { HomeLocationID = value; }
        }
        public Guid rowguid
        {
            get { return rowguid; }
            protected set { rowguid = value; }
        }
        public string Login
        {
            get { return _Login; }
            protected set { _Login = value; }
        }
        public string rtdsPassword
        {
            get { return _rtdsPassword; }
            protected set { _rtdsPassword = value; }
        }

        public bool Locked
        {
            get { return _Locked;}
            protected set { _Locked = value; }
        }

        public int AccessRightsMask
        {
            get { return _AccessRightsMask; }
            protected set { _AccessRightsMask = value; }
        }

        public Guid ID
        {
            get { return ID; }
            protected set { ID = value; }
        }

        public Employment Employment
        {
            get { return _Employment; }
            set { _Employment = value; }
        }

        public ssUser ssUser
        {
            get { return _ssUser; }
            protected set { _ssUser = value; }
        }

        public int PayrollEmpNum
        {
            get { return _PayrollEmpNum; }
            protected set { PayrollEmpNum = value; }
        }

        public DateTime TermDate
        {
            get { return _TermDate; }
            protected set { _TermDate = value; }
        }
    }

    public class Unloader
    {
        private Guid _EmployeeID;
        private String _EmployeeName;
        private String _EmployeeLogin;

        public Guid EmployeeID 
        { get { return _EmployeeID; } set { _EmployeeID = value; } }
        public string EmployeeName
            { get { return _EmployeeName; } set { _EmployeeName = value; } }
        public string EmployeeLogin
            { get { return _EmployeeLogin; } set { _EmployeeLogin = value; } }
    }

    public class Certification { }

    public class ssUser { }

    public class Employment { }
}