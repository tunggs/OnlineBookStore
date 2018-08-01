using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class AdvertisementBL
    {
        private int _AdvertisementID;
        private string _AdvertisementImage;
        private string _AdvertisementUrl;
        private string _AdvertisementName;
        private string _AdvertisementDescription;
        private int _AdvertisementSort;
        private int _AdvertisementActive;

        public AdvertisementBL()
        {

        }

        public AdvertisementBL(int AdvertisementID_, 
                               string AdvertisementImage_, 
                               string AdvertisementUrl_, 
                               string AdvertisementName_, 
                               string AdvertisementDescription_, 
                               int AdvertisementSort_, 
                               int AdvertisementActive_)
        {
            _AdvertisementID = AdvertisementID_;
            _AdvertisementImage = AdvertisementImage_;
            _AdvertisementUrl = AdvertisementUrl_;
            _AdvertisementName = AdvertisementName_;
            _AdvertisementDescription = AdvertisementDescription_;
            _AdvertisementSort = AdvertisementSort_;
            _AdvertisementActive = AdvertisementActive_;
        }

        public AdvertisementBL(string AdvertisementImage_,
                               string AdvertisementUrl_,
                               string AdvertisementName_,
                               string AdvertisementDescription_,
                               int AdvertisementSort_,
                               int AdvertisementActive_)
        {
            _AdvertisementImage = AdvertisementImage_;
            _AdvertisementUrl = AdvertisementUrl_;
            _AdvertisementName = AdvertisementName_;
            _AdvertisementDescription = AdvertisementDescription_;
            _AdvertisementSort = AdvertisementSort_;
            _AdvertisementActive = AdvertisementActive_;
        }

        public AdvertisementBL(int AdvertisementID_,
                               string AdvertisementImage_,
                               string AdvertisementUrl_,
                               string AdvertisementName_,
                               string AdvertisementDescription_,
                               int AdvertisementActive_)
        {
            _AdvertisementID = AdvertisementID_;
            _AdvertisementImage = AdvertisementImage_;
            _AdvertisementUrl = AdvertisementUrl_;
            _AdvertisementName = AdvertisementName_;
            _AdvertisementDescription = AdvertisementDescription_;
            _AdvertisementActive = AdvertisementActive_;
        }

        public AdvertisementBL(int AdvertisementID_,
                               int AdvertisementSort_)
        {
            _AdvertisementID = AdvertisementID_;
            _AdvertisementSort = AdvertisementSort_;
        }

        public AdvertisementBL(int AdvertisementID_)
        {
            _AdvertisementID = AdvertisementID_;
        }

        //new way of declaring getter and setter
        public int AdvertisementID { get => _AdvertisementID; set => _AdvertisementID = value; }
        public string AdvertisementImage { get => _AdvertisementImage; set => _AdvertisementImage = value; }
        public string AdvertisementUrl { get => _AdvertisementUrl; set => _AdvertisementUrl = value; }
        public string AdvertisementName { get => _AdvertisementName; set => _AdvertisementName = value; }
        public string AdvertisementDescription { get => _AdvertisementDescription; set => _AdvertisementDescription = value; }
        public int AdvertisementSort { get => _AdvertisementSort; set => _AdvertisementSort = value; }
        public int AdvertisementActive { get => _AdvertisementActive; set => _AdvertisementActive = value; }
    }
}
