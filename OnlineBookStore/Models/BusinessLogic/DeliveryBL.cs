using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class DeliveryBL
    {
        private int _DeliveryID;
        private string _DeliveryCustomerName;
        private string _DeliveryDescription;
        private float _DeliveryFee;
        private int _DeliverySort;
        private int _DeliveryActive;

        public DeliveryBL()
        {

        }

        public DeliveryBL(int DeliveryID_, 
                          string DeliveryCustomerName_, 
                          string DeliveryDescription_, 
                          float DeliveryFee_, 
                          int DeliverySort_, 
                          int DeliveryActive_)
        {
            _DeliveryID = DeliveryID_;
            _DeliveryCustomerName = DeliveryCustomerName_;
            _DeliveryDescription = DeliveryDescription_;
            _DeliveryFee = DeliveryFee_;
            _DeliverySort = DeliverySort_;
            _DeliveryActive = DeliveryActive_;
        }

        public DeliveryBL(string DeliveryCustomerName_, 
                          string DeliveryDescription_, 
                          float DeliveryFee_, 
                          int DeliverySort_, 
                          int DeliveryActive_)
        {
            _DeliveryCustomerName = DeliveryCustomerName_;
            _DeliveryDescription = DeliveryDescription_;
            _DeliveryFee = DeliveryFee_;
            _DeliverySort = DeliverySort_;
            _DeliveryActive = DeliveryActive_;
        }

        public DeliveryBL(int DeliveryID_, 
                          string DeliveryCustomerName_, 
                          string DeliveryDescription_, 
                          float DeliveryFee_, 
                          int DeliveryActive_)
        {
            _DeliveryID = DeliveryID_;
            _DeliveryCustomerName = DeliveryCustomerName_;
            _DeliveryDescription = DeliveryDescription_;
            _DeliveryFee = DeliveryFee_;
            _DeliveryActive = DeliveryActive_;
        }

        public DeliveryBL(int DeliveryID_, 
                          int DeliverySort_)
        {
            _DeliveryID = DeliveryID_;
            _DeliverySort = DeliverySort_;
        }

        public DeliveryBL(int DeliveryID_)
        {
            _DeliveryID = DeliveryID_;
        }

        public int DeliveryID
        {
            get
            {
                return _DeliveryID;
            }
            set
            {
                _DeliveryID = value;
            }
        }

        public string DeliveryCustomerName
        {
            get
            {
                return _DeliveryCustomerName;
            }
            set
            {
                _DeliveryCustomerName = value;
            }
        }

        public string DeliveryDescription
        {
            get
            {
                return _DeliveryDescription;
            }
            set
            {
                _DeliveryDescription = value;
            }
        }

        public float DeliveryFee
        {
            get
            {
                return _DeliveryFee;
            }
            set
            {
                _DeliveryFee = value;
            }
        }

        public int DeliverySort
        {
            get
            {
                return _DeliverySort;
            }
            set
            {
                _DeliverySort = value;
            }
        }

        public int DeliveryActive
        {
            get
            {
                return _DeliveryActive;
            }
            set
            {
                _DeliveryActive = value;
            }
        }
    }
}
