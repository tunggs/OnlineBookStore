using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class UserBL
    {
        private int _UserID;
        private string _UserLoginName;
        private string _UserPassword;
        private string _UserFullName;
        private DateTime _UserDateOfBirth;
        private string _UserEmail;
        private string _UserPhoneNumber;
        private string _UserAddress;
        private int _UserActive;
        private DateTime _UserDateCreated;
        private int _UserRole;

        public UserBL()
        {

        }

        public UserBL(int UserID_, 
                      string UserLoginName_, 
                      string UserPassword_, 
                      string UserFullName_, 
                      DateTime UserDateOfBirth_, 
                      string UserEmail_, 
                      string UserPhoneNumber_,
                      string UserAddress_, 
                      int UserActive_, 
                      DateTime UserDateCreated_, 
                      int UserRole_)
        {
            _UserID = UserID_;
            _UserLoginName = UserLoginName_;
            _UserPassword = UserPassword_;
            _UserFullName = UserFullName_;
            _UserDateOfBirth = UserDateOfBirth_;
            _UserEmail = UserEmail_;
            _UserPhoneNumber = UserPhoneNumber_;
            _UserAddress = UserAddress_;
            _UserActive = UserActive_;
            _UserDateCreated = UserDateCreated_;
            _UserRole = UserRole_;
        }

        public UserBL(string UserLoginName_,
                      string UserPassword_,
                      string UserFullName_,
                      DateTime UserDateOfBirth_,
                      string UserEmail_,
                      string UserPhoneNumber_,
                      string UserAddress_,
                      int UserActive_,
                      DateTime UserDateCreated_,
                      int UserRole_)
        {
            _UserLoginName = UserLoginName_;
            _UserPassword = UserPassword_;
            _UserFullName = UserFullName_;
            _UserDateOfBirth = UserDateOfBirth_;
            _UserEmail = UserEmail_;
            _UserPhoneNumber = UserPhoneNumber_;
            _UserAddress = UserAddress_;
            _UserActive = UserActive_;
            _UserDateCreated = UserDateCreated_;
            _UserRole = UserRole_;
        }

        public UserBL(int UserID_,
                     string UserLoginName_,
                     string UserPassword_,
                     string UserFullName_,
                     DateTime UserDateOfBirth_,
                     string UserEmail_,
                     string UserPhoneNumber_,
                     string UserAddress_,
                     int UserActive_,
                     int UserRole_)
        {
            _UserID = UserID_;
            _UserLoginName = UserLoginName_;
            _UserPassword = UserPassword_;
            _UserFullName = UserFullName_;
            _UserDateOfBirth = UserDateOfBirth_;
            _UserEmail = UserEmail_;
            _UserPhoneNumber = UserPhoneNumber_;
            _UserAddress = UserAddress_;
            _UserActive = UserActive_;
            _UserRole = UserRole_;
        }

        public UserBL(string UserLoginName_, 
                      string UserPassword_)
        {
            _UserLoginName = UserLoginName_;
            _UserPassword = UserPassword_;
        }

        public UserBL(int UserID_, string UserPassword_)
        {
            _UserID = UserID_;
            _UserPassword = UserPassword_;
        }
        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
        public string UserLoginName
        {
            get
            {
                return _UserLoginName;
            }
            set
            {
                _UserLoginName = value;
            }
        }
        public string UserPassword
        {
            get
            {
                return _UserPassword;
            }
            set
            {
                _UserPassword = value;
            }
        }
        public string UserFullName
        {
            get
            {
                return _UserFullName;
            }
            set
            {
                _UserFullName = value;
            }
        }
        public DateTime UserDateOfBirth
        {
            get
            {
                return _UserDateOfBirth;
            }
            set
            {
                _UserDateOfBirth = value;
            }
        }
        public string UserEmail
        {
            get
            {
                return _UserEmail;
            }
            set
            {
                _UserEmail = value;
            }
        }
        public string UserPhoneNumber
        {
            get
            {
                return _UserPhoneNumber;
            }
            set
            {
                _UserPhoneNumber = value;
            }
        }
        public string UserAddress
        {
            get
            {
                return _UserAddress;
            }
            set
            {
                _UserAddress = value;
            }
        }
        public int UserActive
        {
            get
            {
                return _UserActive;
            }
            set
            {
                _UserActive = value;
            }
        }
        public DateTime UserDateCreated
        {
            get
            {
                return _UserDateCreated;
            }
            set
            {
                _UserDateCreated = value;
            }
        }
        public int UserRole
        {
            get
            {
                return _UserRole;
            }
            set
            {
                _UserRole = value;
            }
        }
    }
}
