using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace seuWinDock.Models
{
    class WorkOrder
    {
        private Int16 _Status;
        private DateTime _LogDate;
        private Int32 _LogNumber;
        private String _LoadNumber;
        private Guid _LocationID;
        private Guid _DepartmentID;
        private String _Department;
        private String _LoadTypeID;
        private String _LoadType;     //not in workorder table
        private Guid _CustomerID;
        private String _VendorNumber;
        private String _VendorName;     //not in workorder table
        private String _ReceiptNumber;  //NEVER ON Backhaul/Inbound default to -1
        private String _PurchaseOrder;
        private String _PaymentType;
        private Decimal _Amount;
        private Decimal _SplitPaymentAmount;
        private Boolean _IsCash;     //always false on backhaul/inbound
        private Guid _LoadDescriptionID;
        private String _LoadDescription;    //not in workorder table
        private Guid _CarrierID;
        private String _CarrierName;     //not in workorder table
        private String _TruckNumber;      //if empty "DROP"   
        private String _TrailerNumber;   //
        private DateTime _AppointmentTime;   //1/1/1900
        private DateTime _GateTime;   //1/1/1900
        private DateTime _DockTime;
        private DateTime _StartTime;
        private DateTime _CompTime;
        private Int16 _TTLTime; //in minutes
        private Int16 _PalletsUnloaded;
        private String _DoorNumber;
        private Int32 _Pieces;
        private Int32 _Weight;
        private String _Comments;
        private Int16 _Restacks;
        private Int16 _PalletsReceived;
        private Int16 _BadPallets;
        private Int32 _NumberOfItems;
        private String _CheckNumber;     //or null
        private String _BOL;             //or null
        private Guid _ID;        //the ONLY not null
        private Boolean _isClosed;    //not in workorder table
        private List<String> _Employee;   //not in workorder table
        //'  UPDATE FOR DATABASE
        private String _CreatedBy;

        public WorkOrder()
            {
                _ID = Guid.NewGuid();
                _LogDate = DateTime.Now;
                _LogNumber = -1;
                _LoadNumber = _LogDate.ToString("MMddHHmmss");
                _ReceiptNumber = _LoadNumber;
                _BadPallets = -1;
                _Restacks = -1;
                _Weight = -1;
                _PalletsUnloaded = -1;
                _NumberOfItems = -1;
                _AppointmentTime = Convert.ToDateTime("1/1/1900 12:00 AM");
                _GateTime = Convert.ToDateTime("1/1/1900 12:00 AM");
                _StartTime = Convert.ToDateTime("1/1/1900 12:00 AM");
                _CompTime = Convert.ToDateTime("1/1/1900 12:00 AM");
                _DockTime = Convert.ToDateTime("1/1/1900 12:00 AM");
            }
        public Int16 Status
            { get { return _Status; } set { _Status = value; } }
        public DateTime LogDate
            { get { return _LogDate; } set { _LogDate = value; } }
        public Int32 LogNumber
            { get { return _LogNumber; } set { _LogNumber = value; } }
        public String LoadNumber
            { get { return _LoadNumber; } set { _LoadNumber = value; } }
        public Guid LocationID
            { get { return _LocationID; } set { _LocationID = value; } }
        public Guid DepartmentID
            { get { return _DepartmentID; } set { _DepartmentID = value; } }
        public String Department
            { get { return _Department; } set { _Department = value; } }
        public String LoadTypeID
            { get { return _LoadTypeID; } set { _LoadTypeID = value; } }
        public String LoadType
        { get { return _LoadType; } set { _LoadType = value; } }        //not in workorder table
        public Guid CustomerID
            { get { return _CustomerID; } set { _CustomerID = value; } }
        public String VendorNumber
            { get { return _VendorNumber; } set { _VendorNumber = value; } }
        public String VendorName
            { get { return _VendorName; } set { _VendorName = value; } }        //not in workorder table
        public String ReceiptNumber
            { get { return _ReceiptNumber; } set { _ReceiptNumber = value; } }        //NEVER ON Backhaul/Inbound default to -1
        public String PurchaseOrder
            { get { return _PurchaseOrder; } set { _PurchaseOrder = value; } }
        public String PaymentType
            { get { return _PaymentType; } set { _PaymentType = value; } }
        public Decimal Amount
            { get { return _Amount; } set { _Amount = value; } }
        public Decimal SplitPaymentAmount
            { get { return _SplitPaymentAmount; } set { _SplitPaymentAmount = value; } }
        public Boolean IsCash
            { get { return _IsCash; } set { _IsCash = value; } }        //always false on backhaul/inbound
        public Guid LoadDescriptionID
           { get { return _LoadDescriptionID; } set { _LoadDescriptionID = value; } }
        public String LoadDescription
            { get { return _LoadDescription; } set { _LoadDescription = value; } }        //not in workorder table
        public Guid CarrierID
            { get { return CarrierID; } set { CarrierID = value; } }
        public String CarrierName
            { get { return _CarrierName; } set { _CarrierName = value; } }        //not in workorder table
        public String TruckNumber
          { get { return _TruckNumber; } set { _TruckNumber = value; } }        //if empty "DROP"   
        public String TrailerNumber
          { get { return _TrailerNumber; } set { _TrailerNumber = value; } }
        public DateTime AppointmentTime
           { get { return _AppointmentTime; } set { _AppointmentTime = value; } }        //1/1/1900
        public DateTime GateTime
            { get { return _GateTime; } set { _GateTime = value; } }        //1/1/1900
        public DateTime DockTime
            { get { return _DockTime; } set { _DockTime = value; } }
        public DateTime StartTime
            { get { return _StartTime; } set { _StartTime = value; } }
        public DateTime CompTime
            { get { return _CompTime; } set { _CompTime = value; } }
        public Int16 TTLTime
           { get { return _TTLTime; } set { _TTLTime = value; } }        //in minutes
        public Int16 PalletsUnloaded
            { get { return _PalletsUnloaded; } set { _PalletsUnloaded = value; } }
        public String DoorNumber
            { get { return _DoorNumber; } set { _DoorNumber = value; } }
        public Int32 Pieces
            { get { return _Pieces; } set { _Pieces = value; } }
        public Int32 Weight
            { get { return _Weight; } set { _Weight = value; } }
        public String Comments
            { get { return _Comments; } set { _Comments = value; } }
        public Int16 Restacks
           { get { return _Restacks; } set { _Restacks = value; } }
        public Int16 PalletsReceived
            { get { return _PalletsReceived; } set { _PalletsReceived = value; } }
        public Int16 BadPallets
            { get { return _BadPallets; } set { _BadPallets = value; } }
        public Int32 NumberOfItems
        { get { return _NumberOfItems; } set { _NumberOfItems = value; } }
        public String CheckNumber
            { get { return _CheckNumber; } set { _CheckNumber = value; } }        //or null
        public String BOL
            { get { return _BOL; } set { _BOL = value; } }        //or null
        public Guid ID
            { get { return _ID; } set { _ID = value; } }        //the ONLY not null
        public Boolean isClosed
            { get { return _isClosed; } set { _isClosed = value; } }        //not in workorder table
        public List<String> Employee
            { get { return _Employee; } set { _Employee = value; } }
        //not in workorder table
        //'  UPDATE FOR DATABASE
        public String CreatedBy
            { get { return _CreatedBy; } set { _CreatedBy = value; } }
    }
}
