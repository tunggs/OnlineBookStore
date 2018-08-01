using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class ContactBL
    {
        private int _ContactID;
        private string _ContactFullName;
        private string _ContactEmail;
        private string _ContactPhoneNumber;
        private string _ContactTitle;
        private string _ContactContent;
        private DateTime _ContactDateUpdated;
        private DateTime _ContactDateCreated;
        private int _ContactActive;

        public ContactBL()
        {

        }

        public ContactBL(int ContactID_, 
                         string ContactFullName_, 
                         string ContactEmail_, 
                         string ContactPhoneNumber_, 
                         string ContactTitle_, 
                         string ContactContent_,
                         DateTime ContactDateUpdated_, 
                         DateTime ContactDateCreated_, 
                         int ContactActive_)
        {
            _ContactID = ContactID_;
            _ContactFullName = ContactFullName_;
            _ContactEmail = ContactEmail_;
            _ContactPhoneNumber = ContactPhoneNumber_;
            _ContactTitle = ContactTitle_;
            _ContactContent = ContactContent_;
            _ContactDateUpdated = ContactDateUpdated_;
            _ContactDateCreated = ContactDateCreated_;
            _ContactActive = ContactActive_;
        }

        public ContactBL(string ContactFullName_, 
                         string ContactEmail_, 
                         string ContactPhoneNumber_, 
                         string ContactTitle_, 
                         string ContactContent_,
                         DateTime ContactDateUpdated_, 
                         DateTime ContactDateCreated_, 
                         int ContactActive_)
        {
            _ContactFullName = ContactFullName_;
            _ContactEmail = ContactEmail_;
            _ContactPhoneNumber = ContactPhoneNumber_;
            _ContactTitle = ContactTitle_;
            _ContactContent = ContactContent_;
            _ContactDateUpdated = ContactDateUpdated_;
            _ContactDateCreated = ContactDateCreated_;
            _ContactActive = ContactActive_;
        }

        public ContactBL(int ContactID_, DateTime ContactDateUpdated_, int ContactActive_)
        {
            _ContactID = ContactID_;
            _ContactDateUpdated = ContactDateUpdated_;
            _ContactActive = ContactActive_;
        }

        public ContactBL(int ContactID_)
        {
            _ContactID = ContactID_;
        }

        public int ContactID
        {
            get
            {
                return _ContactID;
            }
            set
            {
                _ContactID = value;
            }
        }

        public string ContactFullName
        {
            get
            {
                return _ContactFullName;
            }
            set
            {
                _ContactFullName = value;
            }
        }

        public string ContactEmail
        {
            get
            {
                return _ContactEmail;
            }
            set
            {
                _ContactEmail = value;
            }
        }

        public string ContactPhoneNumber
        {
            get
            {
                return _ContactPhoneNumber;
            }
            set
            {
                _ContactPhoneNumber = value;
            }
        }

        public string ContactTitle
        {
            get
            {
                return _ContactTitle;
            }
            set
            {
                _ContactTitle = value;
            }
        }

        public string ContactContent
        {
            get
            {
                return _ContactContent;
            }
            set
            {
                _ContactContent = value;
            }
        }

        public DateTime ContactDateUpdated
        {
            get
            {
                return _ContactDateUpdated;
            }
            set
            {
                _ContactDateUpdated = value;
            }
        }

        public DateTime ContactDateCreated
        {
            get
            {
                return _ContactDateCreated;
            }
            set
            {
                _ContactDateCreated = value;
            }
        }

        public int ContactActive
        {
            get
            {
                return _ContactActive;
            }
            set
            {
                _ContactActive = value;
            }
        }
    }
}
