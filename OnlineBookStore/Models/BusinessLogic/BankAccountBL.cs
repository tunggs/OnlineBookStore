using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class BankAccountBL
    {
        private int _BankAccountID;
        private string _AccountName;
        private string _AccountNumber;
        private float _TotalAmount;
        private float _ReservedAmount;
        private DateTime _ValidateFrom;
        private DateTime _ValidateTo;
        private int _Active;

        public BankAccountBL()
        {

        }

        public BankAccountBL(int BankAccountID_, 
                             string AccountName_, 
                             string AccountNumber_, 
                             float TotalAmount_, 
                             float ReservedAmount_,
                             DateTime ValidateFrom_, 
                             DateTime ValidateTo_, 
                             int Active_)
        {
            _BankAccountID = BankAccountID_;
            _AccountName = AccountName_;
            _AccountNumber = AccountNumber_;
            _TotalAmount = TotalAmount_;
            _ReservedAmount = ReservedAmount_;
            _ValidateFrom = ValidateFrom_;
            _ValidateTo = ValidateTo_;
            _Active = Active_;
        }

        public BankAccountBL(string AccountName_, 
                             string AccountNumber_)
        {
            _AccountName = AccountName_;
            _AccountNumber = AccountNumber_;
        }
        public BankAccountBL(int BankAccountID_, 
                             float TotalAmount_)
        {
            _BankAccountID = BankAccountID_;
            _TotalAmount = TotalAmount_;
        }

        public int BankAccountID
        {
            get
            {
                return _BankAccountID;
            }
            set
            {
                _BankAccountID = value;
            }
        }

        public string AccountName
        {
            get
            {
                return _AccountName;
            }
            set
            {
                _AccountName = value;
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
        public DateTime ValidateFrom
        {
            get
            {
                return _ValidateFrom;
            }
            set
            {
                _ValidateFrom = value;
            }
        }

        public DateTime ValidateTo
        {
            get
            {
                return _ValidateTo;
            }
            set
            {
                _ValidateTo = value;
            }
        }

        public int Active
        {
            get
            {
                return _Active;
            }
            set
            {
                _Active = value;
            }
        }
    }
}
