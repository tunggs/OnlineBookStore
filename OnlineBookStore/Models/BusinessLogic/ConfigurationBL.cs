using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class ConfigurationBL
    {
        private int _ConfigurationID;
        private string _ConfigurationBanner;
        private int _ConfigurationWidth;
        private int _ConfigurationHeight;
        private string _ConfigurationTitle;
        private string _ConfigurationKeyword;
        private string _ConfigurationDescription;
        private string _ConfigurationInfo;
        private string _ConfigurationCopyright;

        public ConfigurationBL() {

        }

        public ConfigurationBL(int ConfigurationID_, 
                               string ConfigurationBanner_, 
                               int ConfigurationWidth_, 
                               int ConfigurationHeight_, 
                               string ConfigurationTitle_,
                               string ConfigurationKeyword_, 
                               string ConfigurationDescription_, 
                               string ConfigurationInfo_, 
                               string ConfigurationCopyright_)
        {
            _ConfigurationID = ConfigurationID_;
            _ConfigurationBanner = ConfigurationBanner_;
            _ConfigurationWidth = ConfigurationWidth_;
            _ConfigurationHeight = ConfigurationHeight_;
            _ConfigurationTitle = ConfigurationTitle_;
            _ConfigurationKeyword = ConfigurationKeyword_;
            _ConfigurationDescription = ConfigurationDescription_;
            _ConfigurationInfo = ConfigurationInfo_;
            _ConfigurationCopyright = ConfigurationCopyright_;
        }
        public ConfigurationBL(int ConfigurationID_)
        {
            _ConfigurationID = ConfigurationID_;
        }
        public int ConfigurationID
        {
            get
            {
                return _ConfigurationID;
            }
            set
            {
                _ConfigurationID = value;
            }
        }
        public string ConfigurationBanner
        {
            get
            {
                return _ConfigurationBanner;
            }
            set
            {
                _ConfigurationBanner = value;
            }
        }
        public int ConfigurationWidth
        {
            get
            {
                return _ConfigurationWidth;
            }
            set
            {
                _ConfigurationWidth = value;
            }
        }
        public int ConfigurationHeight
        {
            get
            {
                return _ConfigurationHeight;
            }
            set
            {
                _ConfigurationHeight = value;
            }
        }
        public string ConfigurationTitle
        {
            get
            {
                return _ConfigurationTitle;
            }
            set
            {
                _ConfigurationTitle = value;
            }
        }
        public string ConfigurationKeyword
        {
            get
            {
                return _ConfigurationKeyword;
            }
            set
            {
                _ConfigurationKeyword = value;
            }
        }
        public string ConfigurationDescription
        {
            get
            {
                return _ConfigurationDescription;
            }
            set
            {
                _ConfigurationDescription = value;
            }
        }
        public string ConfigurationInfo
        {
            get
            {
                return _ConfigurationInfo;
            }
            set
            {
                _ConfigurationInfo = value;
            }
        }
        public string ConfigurationCopyright
        {
            get
            {
                return _ConfigurationCopyright;
            }
            set
            {
                _ConfigurationCopyright = value;
            }
        }
    }
}
