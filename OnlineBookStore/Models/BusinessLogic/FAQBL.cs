using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class FAQBL
    {
        private int _FAQID;
        private string _FAQQuestion;
        private string _FAQAnswer;
        private int _FAQSort;
        private int _FAQActive;

        public FAQBL()
        {

        }

        public FAQBL(int FAQID_, 
                     string FAQQuestion_, 
                     string FAQAnswer_, 
                     int FAQSort_, 
                     int FAQActive_)
        {
            _FAQID = FAQID_;
            _FAQQuestion = FAQQuestion_;
            _FAQAnswer = FAQAnswer_;
            _FAQSort = FAQSort_;
            _FAQActive = FAQActive_;
        }

        public FAQBL(string FAQQuestion_, 
                     string FAQAnswer_, 
                     int FAQSort_, 
                     int FAQActive_)
        {
            _FAQQuestion = FAQQuestion_;
            _FAQAnswer = FAQAnswer_;
            _FAQSort = FAQSort_;
            _FAQActive = FAQActive_;
        }


        public FAQBL(int FAQID_, 
                     string FAQQuestion_, 
                     string FAQAnswer_, 
                     int FAQActive_)
        {
            _FAQID = FAQID_;
            _FAQQuestion = FAQQuestion_;
            _FAQAnswer = FAQAnswer_;
            _FAQActive = FAQActive_;
        }

        public FAQBL(int FAQID_, 
                     int FAQSort_)
        {
            _FAQID = FAQID_;
            _FAQSort = FAQSort_;
        }

        public FAQBL(int FAQID_)
        {
            _FAQID = FAQID_;
        }

        public int FAQID
        {
            get
            {
                return _FAQID;
            }
            set
            {
                _FAQID = value;
            }
        }

        public string FAQQuestion
        {
            get
            {
                return _FAQQuestion;
            }
            set
            {
                _FAQQuestion = value;
            }
        }

        public string FAQAnswer
        {
            get
            {
                return _FAQAnswer;
            }
            set
            {
                _FAQAnswer = value;
            }
        }

        public int FAQSort
        {
            get
            {
                return _FAQSort;
            }
            set
            {
                _FAQSort = value;
            }
        }

        public int FAQActive
        {
            get
            {
                return _FAQActive;
            }
            set
            {
                _FAQActive = value;
            }
        }
    }
}
