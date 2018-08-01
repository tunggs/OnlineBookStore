using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class CustomerBL
    {
        private int _CustomerID;
        private string _CustomerEmail;
        private string _CustomerPassword;
        private string _CustomerFullName;
        private string _CustomerCompany;
        private string _CustomerAddress1;
        private string _CustomerAddress2;
        private string _CustomerPhoneNumber1;
        private string _CustomerPhoneNumber2;
        private string _CustomerFaxNumber;
        private DateTime _CustomerDateCreated;
        private int _CustomerActive;

        public CustomerBL()
        {

        }

        public CustomerBL(int CustomerID_, 
                          string CustomerEmail_, 
                          string CustomerPassword_, 
                          string CustomerFullName_, 
                          string CustomerCompany_, 
                          string CustomerAddress1_,
                          string CustomerAddress2_, 
                          string CustomerPhoneNumber1_, 
                          string CustomerPhoneNumber2_, 
                          string CustomerFaxNumber_, 
                          DateTime CustomerDateCreated_, 
                          int CustomerActive_)
        {
            _CustomerID = CustomerID_;
            _CustomerEmail = CustomerEmail_;
            _CustomerPassword = CustomerPassword_;
            _CustomerFullName = CustomerFullName_;
            _CustomerCompany = CustomerCompany_;
            _CustomerAddress1 = CustomerAddress1_;
            _CustomerAddress2 = CustomerAddress2_;
            _CustomerPhoneNumber1 = CustomerPhoneNumber1_;
            _CustomerPhoneNumber2 = CustomerPhoneNumber2_;
            _CustomerFaxNumber = CustomerFaxNumber_;
            _CustomerDateCreated = CustomerDateCreated_;
            _CustomerActive = CustomerActive_;
        }
        public CustomerBL(string CustomerEmail_, 
                          string CustomerPassword_, 
                          string CustomerFullName_, 
                          string CustomerCompany_, 
                          string CustomerAddress1_,
                          string CustomerAddress2_, 
                          string CustomerPhoneNumber1_, 
                          string CustomerPhoneNumber2_, 
                          string CustomerFaxNumber_, 
                          DateTime CustomerDateCreated_, 
                          int CustomerActive_)
        {
            _CustomerEmail = CustomerEmail_;
            _CustomerPassword = CustomerPassword_;
            _CustomerFullName = CustomerFullName_;
            _CustomerCompany = CustomerCompany_;
            _CustomerAddress1 = CustomerAddress1_;
            _CustomerAddress2 = CustomerAddress2_;
            _CustomerPhoneNumber1 = CustomerPhoneNumber1_;
            _CustomerPhoneNumber2 = CustomerPhoneNumber2_;
            _CustomerFaxNumber = CustomerFaxNumber_;
            _CustomerDateCreated = CustomerDateCreated_;
            _CustomerActive = CustomerActive_;
        }
        public CustomerBL(int CustomerID_, 
                          string CustomerFullName_, 
                          string CustomerCompany_, 
                          string CustomerAddress1_,
                          string CustomerAddress2_, 
                          string CustomerPhoneNumber1_, 
                          string CustomerPhoneNumber2_, 
                          string CustomerFaxNumber_, 
                          int CustomerActive_)
        {
            _CustomerID = CustomerID_;
            _CustomerFullName = CustomerFullName_;
            _CustomerCompany = CustomerCompany_;
            _CustomerAddress1 = CustomerAddress1_;
            _CustomerAddress2 = CustomerAddress2_;
            _CustomerPhoneNumber1 = CustomerPhoneNumber1_;
            _CustomerPhoneNumber2 = CustomerPhoneNumber2_;
            _CustomerFaxNumber = CustomerFaxNumber_;
            _CustomerActive = CustomerActive_;
        }

        // Pay attention to this - why we not add Phonenumber2 and others
        public CustomerBL(int CustomerID_, 
                          string CustomerFullName_, 
                          string CustomerEmail_, 
                          string CustomerAddress1_, 
                          string CustomerPhoneNumber1_)
        {
            _CustomerID = CustomerID_;
            _CustomerFullName = CustomerFullName_;
            _CustomerEmail = CustomerEmail_;
            _CustomerAddress1 = CustomerAddress1_;
            _CustomerPhoneNumber1 = CustomerPhoneNumber1_;
        }

        public CustomerBL(int CustomerID_, 
                          string CustomerPassword_)
        {
            _CustomerID = CustomerID_;
            _CustomerPassword = CustomerPassword_;
        }

        public CustomerBL(int CustomerID_)
        {
            _CustomerID = CustomerID_;
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

        public string CustomerEmail
        {
            get
            {
                return _CustomerEmail;
            }
            set
            {
                _CustomerEmail = value;
            }
        }

        public string CustomerPassword
        {
            get
            {
                return _CustomerPassword;
            }
            set
            {
                _CustomerPassword = value;
            }
        }

        public string CustomerFullName
        {
            get
            {
                return _CustomerFullName;
            }
            set
            {
                _CustomerFullName = value;
            }
        }

        public string CustomerCompany
        {
            get
            {
                return _CustomerCompany;
            }
            set
            {
                _CustomerCompany = value;
            }
        }

        public string CustomerAddress1
        {
            get
            {
                return _CustomerAddress1;
            }
            set
            {
                _CustomerAddress1 = value;
            }
        }

        public string CustomerAddress2
        {
            get
            {
                return _CustomerAddress2;
            }
            set
            {
                _CustomerAddress2 = value;
            }
        }

        public string CustomerPhoneNumber1
        {
            get
            {
                return _CustomerPhoneNumber1;
            }
            set
            {
                _CustomerPhoneNumber1 = value;
            }
        }

        public string CustomerPhoneNumber2
        {
            get
            {
                return _CustomerPhoneNumber2;
            }
            set
            {
                _CustomerPhoneNumber2 = value;
            }
        }

        public string CustomerFaxNumber
        {
            get
            {
                return _CustomerFaxNumber;
            }
            set
            {
                _CustomerFaxNumber = value;
            }
        }

        public DateTime CustomerDateCreated
        {
            get
            {
                return _CustomerDateCreated;
            }
            set
            {
                _CustomerDateCreated = value;
            }
        }
        public int CustomerActive
        {
            get
            {
                return _CustomerActive;
            }
            set
            {
                _CustomerActive = value;
            }
        }
    }
}
