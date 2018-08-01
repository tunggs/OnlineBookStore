using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class AccountBL
    {
        private int _AccountID;
        private int _CustomerID;
        private string _AccountNumber;
        private float _TotalAmount;
        private float _ReservedAmount;

        public AccountBL()
        {

        }

        public AccountBL(int AccountID_, 
                         int CustomerID_, 
                         string AccountNumber_, 
                         float TotalAmount_, 
                         float ReservedAmount_)
        {
            _AccountID = AccountID_;
            _CustomerID = CustomerID_;
            _AccountNumber = AccountNumber_;
            _TotalAmount = TotalAmount_;
            _ReservedAmount = ReservedAmount_;
        }

        public AccountBL(int AccountID_)
        {
            _AccountID = AccountID_;
        }

        public AccountBL(int AccountID_, 
                         string AccountNumber_)
        {
            _AccountID = AccountID_;
            _AccountNumber = AccountNumber_;
        }
        // 'old" way of declaring getters and setters
        public int AccountID
        {
            get
            {
                return _AccountID;
            }
            set
            {
                _AccountID = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                _AccountNumber = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }

        public float TotalAmount
        {
            get
            {
                return _TotalAmount;
            }
            set
            {
                _TotalAmount = value;
            }
        }

        public float ReservedAmount
        {
            get
            {
                return _ReservedAmount;
            }
            set
            {
                _ReservedAmount = value;
            }
        }
    }
}
