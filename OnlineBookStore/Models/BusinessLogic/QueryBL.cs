using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class QueryBL
    {
        private int _QueryID;
        private string _QueryFullName;
        private string _QueryEmail;
        private string _QueryTitle;
        private string _QueryContent;
        private DateTime _QueryDateCreated;
        private DateTime _QueryDateUpdated;
        private int _QueryActive;

        public QueryBL()
        {

        }

        public QueryBL(int QueryID_, 
                       string QueryFullName_, 
                       string QueryEmail_, 
                       string QueryTitle_, 
                       string QueryContent_,
                       DateTime QueryDateCreated_,
                       DateTime QueryDateUpdated_, 
                       int QueryActive_)
        {
            _QueryID = QueryID_;
            _QueryFullName = QueryFullName_;
            _QueryEmail = QueryEmail_;
            _QueryTitle = QueryTitle_;
            _QueryContent = QueryContent_;
            _QueryDateCreated = QueryDateCreated_;
            _QueryDateUpdated = QueryDateUpdated_;
            _QueryActive = QueryActive_;
        }

        public QueryBL(int QueryID_, 
                       DateTime QueryDateUpdated_, 
                       int QueryActive_)
        {
            _QueryID = QueryID_;
            _QueryDateUpdated = QueryDateUpdated_;
            _QueryActive = QueryActive_;
        }

        public QueryBL(string QueryFullName_, 
                       string QueryEmail_, 
                       string QueryTitle_, 
                       string QueryContent_,
                       DateTime QueryDateCreated_,
                       DateTime QueryDateUpdated_, 
                       int QueryActive_)
        {
            _QueryFullName = QueryFullName_;
            _QueryEmail = QueryEmail_;
            _QueryTitle = QueryTitle_;
            _QueryContent = QueryContent_;
            _QueryDateCreated = QueryDateCreated_;
            _QueryDateUpdated = QueryDateUpdated_;
            _QueryActive = QueryActive_;
        }

        public QueryBL(int QueryID_)
        {
            _QueryID = QueryID_;
        }

        public int QueryID
        {
            get
            {
                return _QueryID;
            }
            set
            {
                _QueryID = value;
            }
        }

        public string QueryFullName
        {
            get
            {
                return _QueryFullName;
            }
            set
            {
                _QueryFullName = value;
            }
        }

        public string QueryEmail
        {
            get
            {
                return _QueryEmail;
            }
            set
            {
                _QueryEmail = value;
            }
        }

        public string QueryTitle
        {
            get
            {
                return _QueryTitle;
            }
            set
            {
                _QueryTitle = value;
            }
        }

        public string QueryContent
        {
            get
            {
                return _QueryContent;
            }
            set
            {
                _QueryContent = value;
            }
        }

        public DateTime QueryDateUpdated
        {
            get
            {
                return _QueryDateUpdated;
            }
            set
            {
                _QueryDateUpdated = value;
            }
        }

        public DateTime QueryDateCreated
        {
            get
            {
                return _QueryDateCreated;
            }
            set
            {
                _QueryDateCreated = value;
            }
        }

        public int QueryActive
        {
            get
            {
                return _QueryActive;
            }
            set
            {
                _QueryActive = value;
            }
        }
    }
}
