using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class CategoryBL
    {
        private int _CategoryID;
        private int _ParentCategoryID;
        private string _CategoryCode;
        private string _CategoryName;
        private string _CategoryDescription;
        private int _CategorySort;
        private int _CategoryActive;

        public CategoryBL()
        {

        }

        public CategoryBL(int CategoryID_, 
                          int ParentCategoryID_, 
                          string CategoryCode_, 
                          string CategoryName_, 
                          string CategoryDescription_, 
                          int CategorySort_, 
                          int CategoryActive_)
        {
            _CategoryID = CategoryID_;
            _ParentCategoryID = ParentCategoryID_;
            _CategoryCode = CategoryCode_;
            _CategoryName = CategoryName_;
            _CategoryDescription = CategoryDescription_;
            _CategorySort = CategorySort_;
            _CategoryActive = CategoryActive_;
        }

        public CategoryBL(int ParentCategoryID_, 
                          string CategoryCode_, 
                          string CategoryName_, 
                          string CategoryDescription_, 
                          int CategorySort_, 
                          int CategoryActive_)
        {
            _ParentCategoryID = ParentCategoryID_;
            _CategoryCode = CategoryCode_;
            _CategoryName = CategoryName_;
            _CategoryDescription = CategoryDescription_;
            _CategorySort = CategorySort_;
            _CategoryActive = CategoryActive_;
        }

        public CategoryBL(int CategoryID_, 
                          int ParentCategoryID_, 
                          string CategoryCode_, 
                          string CategoryName_, 
                          string CategoryDescription_, 
                          int CategoryActive_)
        {
            _CategoryID = CategoryID_;
            _ParentCategoryID = ParentCategoryID_;
            _CategoryCode = CategoryCode_;
            _CategoryName = CategoryName_;
            _CategoryDescription = CategoryDescription_;
            _CategoryActive = CategoryActive_;
        }

        public CategoryBL(int CategoryID_)
        {
            _CategoryID = CategoryID_;
        }

        public CategoryBL(int CategoryID_, 
                          int CategorySort_)
        {
            _CategoryID = CategoryID_;
            _CategorySort = CategorySort_;
        }
        public CategoryBL(string CategoryCode_)
        {
            _CategoryCode = CategoryCode_;
        }

        public int CategoryID
        {
            get
            {
                return _CategoryID;
            }
            set
            {
                _CategoryID = value;
            }
        }

        public int ParentCategoryID
        {
            get
            {
                return _ParentCategoryID;
            }
            set
            {
                _ParentCategoryID = value;
            }
        }

        public string CategoryCode
        {
            get
            {
                return _CategoryCode;
            }
            set
            {
                _CategoryCode = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return _CategoryName;
            }
            set
            {
                _CategoryName = value;
            }
        }

        public string CategoryDescription
        {
            get
            {
                return _CategoryDescription;
            }
            set
            {
                _CategoryDescription = value;
            }
        }

        public int CategorySort
        {
            get
            {
                return _CategorySort;
            }
            set
            {
                _CategorySort = value;
            }
        }

        public int CategoryActive
        {
            get
            {
                return _CategoryActive;
            }
            set
            {
                _CategoryActive = value;
            }
        }
    }
}
