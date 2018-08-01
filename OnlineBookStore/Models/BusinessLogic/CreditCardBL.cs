using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class CreditCardBL
    {
        private int _CreditCardID;
        private int _AccountID;
        private string _CreditCardNumber;
        private string _CreditCardPassword;
        private DateTime _CreditCardValidateFrom;
        private DateTime _CreditCardValidateTo;

        public CreditCardBL()
        {

        }

        public CreditCardBL(int CreditCardID_, 
                            int AccountID_, 
                            string CreditCardNumber_, 
                            string CreditCardPassword_, 
                            DateTime CreditCardValidateFrom_, 
                            DateTime CreditCardValidateTo_)
        {
            _CreditCardID = CreditCardID_;
            _AccountID = AccountID_;
            _CreditCardNumber = CreditCardNumber_;
            _CreditCardPassword = CreditCardPassword_;
            _CreditCardValidateFrom = CreditCardValidateFrom_;
            _CreditCardValidateTo = CreditCardValidateTo_;
        }

        public CreditCardBL(int CreditCardID_)
        {
            _CreditCardID = CreditCardID_;
        }

        public int CreditCardID
        {
            get
            {
                return _CreditCardID;
            }
            set
            {
                _CreditCardID = value;
            }
        }
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
        public string CreditCardNumber
        {
            get
            {
                return _CreditCardNumber;
            }
            set
            {
                _CreditCardNumber = value;
            }
        }

        public string CreditCardPassword
        {
            get
            {
                return _CreditCardPassword;
            }
            set
            {
                _CreditCardPassword = value;
            }
        }

        public DateTime CreditCardValidateFrom
        {
            get
            {
                return _CreditCardValidateFrom;
            }
            set
            {
                _CreditCardValidateFrom = value;
            }
        }

        public DateTime CreditCardValidateTo
        {
            get
            {
                return _CreditCardValidateTo;
            }
            set
            {
                _CreditCardValidateTo = value;
            }
        }
    }
}
