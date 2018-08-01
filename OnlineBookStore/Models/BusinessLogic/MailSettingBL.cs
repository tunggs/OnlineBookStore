using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class MailSettingBL
    {
        private int _MailSettingID;
        private string _Host;
        private int _Port;
        private string _Email;
        private string _Password;

        public MailSettingBL()
        {

        }
        public MailSettingBL(int MailSettingID_, 
                             string Host_, 
                             int Port_, 
                             string Email_, 
                             string Password_)
        {
            _MailSettingID = MailSettingID_;
            _Host = Host_;
            _Port = Port_;
            _Email = Email_;
            _Password = Password_;
        }
        public MailSettingBL(int MailSettingID_)
        {
            _MailSettingID = MailSettingID_;
        }
        public int MailSettingID
        {
            get
            {
                return _MailSettingID;
            }
            set
            {
                _MailSettingID = value;
            }
        }
        public string Host
        {
            get
            {
                return _Host;
            }
            set
            {
                _Host = value;
            }
        }
        public int Port
        {
            get
            {
                return _Port;
            }
            set
            {
                _Port = value;
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
    }
}
