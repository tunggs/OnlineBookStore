using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class SupportBL
    {
        private int _SupportID;
        private string _OnlineSupportID;
        private string _SupportName;
        private string _SupportDescription;
        private int _SupportType;
        private int _SupportSort;
        private int _SupportActive;

        public SupportBL()
        {

        }

        public SupportBL(int SupportID_, 
                         string OnlineSupportID_, 
                         string SupportName_, 
                         string SupportDescription_, 
                         int SupportType_, 
                         int SupportSort_, 
                         int SupportActive_)
        {
            _SupportID = SupportID_;
            _OnlineSupportID = OnlineSupportID_;
            _SupportName = SupportName_;
            _SupportDescription = SupportDescription_;
            _SupportType = SupportType_;
            _SupportSort = SupportSort_;
            _SupportActive = SupportActive_;
        }

        public SupportBL(string OnlineSupportID_, 
                         string SupportName_, 
                         string SupportDescription_, 
                         int SupportType_, 
                         int SupportSort_, 
                         int SupportActive_)
        {
            _OnlineSupportID = OnlineSupportID_;
            _SupportName = SupportName_;
            _SupportDescription = SupportDescription_;
            _SupportType = SupportType_;
            _SupportSort = SupportSort_;
            _SupportActive = SupportActive_;
        }

        public SupportBL(int SupportID_, 
                         string OnlineSupportID_, 
                         string SupportName_, 
                         string SupportDescription_, 
                         int SupportType_, 
                         int SupportActive_)
        {
            _SupportID = SupportID_;
            _OnlineSupportID = OnlineSupportID_;
            _SupportName = SupportName_;
            _SupportDescription = SupportDescription_;
            _SupportType = SupportType_;
            _SupportActive = SupportActive_;
        }

        public SupportBL(int SupportID_, 
                         int SupportSort_)
        {
            _SupportID = SupportID_;
            _SupportSort = SupportSort_;
        }

        public SupportBL(int SupportID_)
        {
            _SupportID = SupportID_;
        }

        public int SupportID
        {
            get
            {
                return _SupportID;
            }
            set
            {
                _SupportID = value;
            }
        }

        public string OnlineSupportID
        {
            get
            {
                return _OnlineSupportID;
            }
            set
            {
                _OnlineSupportID = value;
            }
        }

        public string SupportName
        {
            get
            {
                return _SupportName;
            }
            set
            {
                _SupportName = value;
            }
        }

        public string SupportDescription
        {
            get
            {
                return _SupportDescription;
            }
            set
            {
                _SupportDescription = value;
            }
        }

        public int SupportType
        {
            get
            {
                return _SupportType;
            }
            set
            {
                _SupportType = value;
            }
        }

        public int SupportSort
        {
            get
            {
                return _SupportSort;
            }
            set
            {
                _SupportSort = value;
            }
        }

        public int SupportActive
        {
            get
            {
                return _SupportActive;
            }
            set
            {
                _SupportActive = value;
            }
        }
    }
}
