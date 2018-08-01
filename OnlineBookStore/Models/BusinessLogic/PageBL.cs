using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class PageBL
    {
        private int _PageID;
        private string _PageTitle;
        private string _PageDetails;
        private int _PageSort;
        private int _PageActive;

        public PageBL()
        {

        }

        public PageBL(int PageID_, 
                      string PageTitle_, 
                      string PageDetails_, 
                      int PageSort_, 
                      int PageActive_)
        {
            _PageID = PageID_;
            _PageTitle = PageTitle_;
            _PageDetails = PageDetails_;
            _PageSort = PageSort_;
            _PageActive = PageActive_;
        }

        public PageBL(string PageTitle_, 
                      string PageDetails_, 
                      int PageSort_, 
                      int PageActive_)
        {
            _PageTitle = PageTitle_;
            _PageDetails = PageDetails_;
            _PageSort = PageSort_;
            _PageActive = PageActive_;
        }

        public PageBL(int PageID_, 
                      string PageTitle_, 
                      string PageDetails_, 
                      int PageActive_)
        {
            _PageID = PageID_;
            _PageTitle = PageTitle_;
            _PageDetails = PageDetails_;
            _PageActive = PageActive_;
        }

        public PageBL(int PageID_, 
                      int PageSort_)
        {
            _PageID = PageID_;
            _PageSort = PageSort_;
        }

        public PageBL(int PageID_)
        {
            _PageID = PageID_;
        }

        public int PageID
        {
            get
            {
                return _PageID;
            }
            set
            {
                _PageID = value;
            }
        }

        public string PageTitle
        {
            get
            {
                return _PageTitle;
            }
            set
            {
                _PageTitle = value;
            }
        }

        public string PageDetails
        {
            get
            {
                return _PageDetails;
            }
            set
            {
                _PageDetails = value;
            }
        }

        public int PageSort
        {
            get
            {
                return _PageSort;
            }
            set
            {
                _PageSort = value;
            }
        }

        public int PageActive
        {
            get
            {
                return _PageActive;
            }
            set
            {
                _PageActive = value;
            }
        }
    }
}
