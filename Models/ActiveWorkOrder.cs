using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seuWinDock.Models
{
    class ActiveWorkOrder
    {
        private String _DoorNumber;
        private String _Vendor;
        private String _PurchaseOrder;
        private String _Carrier;
        private String _TruckNumber;
        private String _TrailerNumber;
        private String _StartTime;
        private String _CompTime;
        private String _Department;
        private String _LoadType;
        private String _Unloaders;
        private Int16 _Status;

        public String DoorNumber
        { get { return _DoorNumber; } set { _DoorNumber = value; } }
        public String Vendor
        { get { return _Vendor; } set { _Vendor = value; } }
        public String PurchaseOrder
        { get { return _PurchaseOrder; } set { _PurchaseOrder = value; } }
        public String Carrier
        { get { return _Carrier; } set { _Carrier = value; } }
        public String TruckNumber
        { get { return _TruckNumber; } set { _TruckNumber = value; } }
        public String TrailerNumber
        { get { return _TrailerNumber; } set { _TrailerNumber = value; } }
        public String StartTime
        { get { return _StartTime; } set { _StartTime = value; } }
        public String CompTime
        { get { return _CompTime; } set { _CompTime = value; } }
        public String Department
        { get { return _Department; } set { _Department = value; } }
        public String LoadType
        { get { return _LoadType; } set { _LoadType = value; } }
        public String Unloaders
        { get { return _Unloaders; } set { _Unloaders = value; } }
        public Int16 Status
        { get { return _Status; } set { _Status = value; } }

        public static List<ActiveWorkOrder> GetLoads()
    {
        var ActiveLoads = new List<ActiveWorkOrder>();
        ActiveLoads.Add(new ActiveWorkOrder
        {
            PurchaseOrder = "12345",
            Vendor = "FrozenIsUS",
            Unloaders = "rf123, ww122, cp123, kg123",
            DoorNumber = "2",
            Carrier = "Bad Habit",
            Status = 20
        });
            ActiveLoads.Add(new ActiveWorkOrder
        {
            PurchaseOrder = "23456",
            Vendor = "GroceryIsUS",
            Unloaders = "ww123, cp123, kg123",
            DoorNumber = "3",
            Carrier = "Blue Badger",
            Status = 30
        });
            ActiveLoads.Add(new ActiveWorkOrder
        {
            PurchaseOrder = "234567",
            Vendor = "ProduceIsUS",
            Unloaders = "rf123, ww123, kg123",
            DoorNumber = "4",
            Carrier = "Silver Streak",
            Status = 40
        });
        return ActiveLoads;
        }
    }

}
