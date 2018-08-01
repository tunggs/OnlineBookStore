using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class PublisherBL
    {
        private int _PublisherID;
        private string _PublisherCode;
        private string _PublisherName;
        private string _PublisherDescription;
        private int _PublisherSort;
        private int _PublisherActive;

        public PublisherBL()
        {

        }

        public PublisherBL(int PublisherID_, 
                           string PublisherCode_, 
                           string PublisherName_, 
                           string PublisherDescription_, 
                           int PublisherSort_, 
                           int PublisherActive_)
        {
            _PublisherID = PublisherID_;
            _PublisherCode = PublisherCode_;
            _PublisherName = PublisherName_;
            _PublisherDescription = PublisherDescription_;
            _PublisherSort = PublisherSort_;
            _PublisherActive = PublisherActive_;
        }

        public PublisherBL(string PublisherCode_, 
                           string PublisherName_, 
                           string PublisherDescription_, 
                           int PublisherSort_, 
                           int PublisherActive_)
        {
            _PublisherCode = PublisherCode_;
            _PublisherName = PublisherName_;
            _PublisherDescription = PublisherDescription_;
            _PublisherSort = PublisherSort_;
            _PublisherActive = PublisherActive_;
        }

        public PublisherBL(int PublisherID_, 
                           string PublisherCode_, 
                           string PublisherName_, 
                           string PublisherDescription_, 
                           int PublisherActive_)
        {
            _PublisherID = PublisherID_;
            _PublisherCode = PublisherCode_;
            _PublisherName = PublisherName_;
            _PublisherDescription = PublisherDescription_;
            _PublisherActive = PublisherActive_;
        }

        public PublisherBL(int PublisherID_, 
                           int PublisherSort_)
        {
            _PublisherID = PublisherID_;
            _PublisherSort = PublisherSort_;
        }

        public PublisherBL(int PublisherID_)
        {
            _PublisherID = PublisherID_;
        }

        public int PublisherID
        {
            get
            {
                return _PublisherID;
            }
            set
            {
                _PublisherID = value;
            }
        }

        public string PublisherCode
        {
            get
            {
                return _PublisherCode;
            }
            set
            {
                _PublisherCode = value;
            }
        }

        public string PublisherName
        {
            get
            {
                return _PublisherName;
            }
            set
            {
                _PublisherName = value;
            }
        }

        public string PublisherDescription
        {
            get
            {
                return _PublisherDescription;
            }
            set
            {
                _PublisherDescription = value;
            }
        }

        public int PublisherSort
        {
            get
            {
                return _PublisherSort;
            }
            set
            {
                _PublisherSort = value;
            }
        }

        public int PublisherActive
        {
            get
            {
                return _PublisherActive;
            }
            set
            {
                _PublisherActive = value;
            }
        }
    }
}
