using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class FeedbackBL
    {
        private int _FeedbackID;
        private int _QueryID;
        private string _FeedbackContent;
        private DateTime _FeedbackDateCreated;
        private DateTime _FeedbackDateUpdated;
        private int _FeedbackActive;

        public FeedbackBL()
        {

        }

        public FeedbackBL(int FeedbackID_, 
                          int QueryID_, 
                          string FeedbackContent_,
                          DateTime FeedbackDateCreated_,
                          DateTime FeedbackDateUpdated_, 
                          int FeedbackActive_)
        {
            _FeedbackID = FeedbackID_;
            _QueryID = QueryID_;
            _FeedbackContent = FeedbackContent_;
            _FeedbackDateCreated = FeedbackDateCreated_;
            _FeedbackDateUpdated = FeedbackDateUpdated_;
            _FeedbackActive = FeedbackActive_;
        }

        public FeedbackBL(int QueryID_, 
                          string FeedbackContent_,
                          DateTime FeedbackDateCreated_,
                          DateTime FeedbackDateUpdated_, 
                          int FeedbackActive_)
        {
            _QueryID = QueryID_;
            _FeedbackContent = FeedbackContent_;
            _FeedbackDateCreated = FeedbackDateCreated_;
            _FeedbackDateUpdated = FeedbackDateUpdated_;
            _FeedbackActive = FeedbackActive_;
        }


        public FeedbackBL(int FeedbackID_, 
                          string FeedbackContent_, 
                          DateTime FeedbackDateUpdated_,
                          int FeedbackActive_)
        {
            _FeedbackID = FeedbackID_;
            _FeedbackContent = FeedbackContent_;
            _FeedbackDateUpdated = FeedbackDateUpdated_;
            _FeedbackActive = FeedbackActive_;
        }

        public FeedbackBL(int QueryID_)
        {
            _QueryID = QueryID_;
        }

        public int FeedbackID
        {
            get
            {
                return _FeedbackID;
            }
            set
            {
                _FeedbackID = value;
            }
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

        public string FeedbackContent
        {
            get
            {
                return _FeedbackContent;
            }
            set
            {
                _FeedbackContent = value;
            }
        }

        public DateTime FeedbackDateUpdated
        {
            get
            {
                return _FeedbackDateUpdated;
            }
            set
            {
                _FeedbackDateUpdated = value;
            }
        }

        public DateTime FeedbackDateCreated
        {
            get
            {
                return _FeedbackDateCreated;
            }
            set
            {
                _FeedbackDateCreated = value;
            }
        }

        public int FeedbackActive
        {
            get
            {
                return _FeedbackActive;
            }
            set
            {
                _FeedbackActive = value;
            }
        }

    }
}
