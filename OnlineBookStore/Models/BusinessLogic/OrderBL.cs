using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class OrderBL
    {
        private int _OrderID;
        private int _CustomerID;
        private int _DeliveryID;
        private string _OrderNumber;
        private float _OrderDiscount;
        private float _OrderTotalPrice;
        private float _OrderTotalMoney;
        private int _OrderPaymentType;
        private string _ShippingName;
        private string _ShippingAddress;
        private string _ShippingEmail;
        private string _ShippingPhoneNumber;
        private DateTime _ShippingDate;
        private int _OrderStatus;
        private DateTime _OrderDateCreated;
        private DateTime _OrderDateUpdated;
        private int _OrderActive;

        public OrderBL()
        {

        }

        public OrderBL(int OrderID_, 
                       int CustomerID_, 
                       int DeliveryID_, 
                       string OrderNumber_, 
                       float OrderDiscount_, 
                       float OrderTotalPrice_,
                       float OrderTotalMoney_, 
                       int OrderPaymentType_, 
                       string ShippingName_, 
                       string ShippingAddress_, 
                       string ShippingEmail_,
                       string ShippingPhoneNumber_, 
                       DateTime ShippingDate_, 
                       int OrderStatus_,
                       DateTime OrderDateCreated_,
                       DateTime OrderDateUpdated_, 
                       int OrderActive_)
        {
            _OrderID = OrderID_;
            _CustomerID = CustomerID_;
            _DeliveryID = DeliveryID_;
            _OrderNumber = OrderNumber_;
            _OrderDiscount = OrderDiscount_;
            _OrderTotalPrice = OrderTotalPrice_;
            _OrderTotalMoney = OrderTotalMoney_;
            _OrderPaymentType = OrderPaymentType_;
            _ShippingName = ShippingName_;
            _ShippingAddress = ShippingAddress_;
            _ShippingEmail = ShippingEmail_;
            _ShippingPhoneNumber = ShippingPhoneNumber_;
            _ShippingDate = ShippingDate_;
            _OrderStatus = OrderStatus_;
            _OrderDateCreated = OrderDateCreated_;
            _OrderDateUpdated = OrderDateUpdated_;
            _OrderActive = OrderActive_;
        }

        public OrderBL(int CustomerID_, 
                       int DeliveryID_, 
                       string OrderNumber_, 
                       float OrderDiscount_, 
                       float OrderTotalPrice_,
                       float OrderTotalMoney_, 
                       int OrderPaymentType_, 
                       string ShippingName_, 
                       string ShippingAddress_, 
                       string ShippingEmail_,
                       string ShippingPhoneNumber_, 
                       DateTime ShippingDate_, 
                       int OrderStatus_,
                       DateTime OrderDateCreated_,
                       DateTime OrderDateUpdated_,  
                       int OrderActive_)
        {
            _CustomerID = CustomerID_;
            _DeliveryID = DeliveryID_;
            _OrderNumber = OrderNumber_;
            _OrderDiscount = OrderDiscount_;
            _OrderTotalPrice = OrderTotalPrice_;
            _OrderTotalMoney = OrderTotalMoney_;
            _OrderPaymentType = OrderPaymentType_;
            _ShippingName = ShippingName_;
            _ShippingAddress = ShippingAddress_;
            _ShippingEmail = ShippingEmail_;
            _ShippingPhoneNumber = ShippingPhoneNumber_;
            _ShippingDate = ShippingDate_;
            _OrderStatus = OrderStatus_;
            _OrderDateCreated = OrderDateCreated_;
            _OrderDateUpdated = OrderDateUpdated_;
            _OrderActive = OrderActive_;
        }

        public OrderBL(int OrderID_, 
                       int DeliveryID_, 
                       float OrderDiscount_, 
                       float OrderTotalPrice_,
                       float OrderTotalMoney_, 
                       string ShippingName_, 
                       string ShippingAddress_, 
                       string ShippingEmail_,
                       string ShippingPhoneNumber_, 
                       DateTime ShippingDate_, 
                       int OrderStatus_, 
                       DateTime OrderDateUpdated_, 
                       int OrderActive_)
        {
            _OrderID = OrderID_;
            _DeliveryID = DeliveryID_;
            _OrderDiscount = OrderDiscount_;
            _OrderTotalPrice = OrderTotalPrice_;
            _OrderTotalMoney = OrderTotalMoney_;
            _ShippingName = ShippingName_;
            _ShippingAddress = ShippingAddress_;
            _ShippingEmail = ShippingEmail_;
            _ShippingPhoneNumber = ShippingPhoneNumber_;
            _ShippingDate = ShippingDate_;
            _OrderStatus = OrderStatus_;
            _OrderDateUpdated = OrderDateUpdated_;
            _OrderActive = OrderActive_;
        }

        public OrderBL(int OrderID_)
        {
            _OrderID = OrderID_;
        }

        public int OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                _OrderID = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }
        public int DeliveryID
        {
            get
            {
                return _DeliveryID;
            }
            set
            {
                _DeliveryID = value;
            }
        }
        public string OrderNumber
        {
            get
            {
                return _OrderNumber;
            }
            set
            {
                _OrderNumber = value;
            }
        }
        public float OrderDiscount
        {
            get
            {
                return _OrderDiscount;
            }
            set
            {
                _OrderDiscount = value;
            }
        }
        public float OrderTotalPrice
        {
            get
            {
                return _OrderTotalPrice;
            }
            set
            {
                _OrderTotalPrice = value;
            }
        }
        public float OrderTotalMoney
        {
            get
            {
                return _OrderTotalMoney;
            }
            set
            {
                _OrderTotalMoney = value;
            }
        }
        public int OrderPaymentType
        {
            get
            {
                return _OrderPaymentType;
            }
            set
            {
                _OrderPaymentType = value;
            }
        }
        public string ShippingName
        {
            get
            {
                return _ShippingName;
            }
            set
            {
                _ShippingName = value;
            }
        }
        public string ShippingAddress
        {
            get
            {
                return _ShippingAddress;
            }
            set
            {
                _ShippingAddress = value;
            }
        }
        public string ShippingEmail
        {
            get
            {
                return _ShippingEmail;
            }
            set
            {
                _ShippingEmail = value;
            }
        }
        public string ShippingPhoneNumber
        {
            get
            {
                return _ShippingPhoneNumber;
            }
            set
            {
                _ShippingPhoneNumber = value;
            }
        }
        public DateTime ShippingDate
        {
            get
            {
                return _ShippingDate;
            }
            set
            {
                _ShippingDate = value;
            }
        }
        public int OrderStatus
        {
            get
            {
                return _OrderStatus;
            }
            set
            {
                _OrderStatus = value;
            }
        }
        public DateTime OrderDateUpdated
        {
            get
            {
                return _OrderDateUpdated;
            }
            set
            {
                _OrderDateUpdated = value;
            }
        }
        public DateTime OrderDateCreated
        {
            get
            {
                return _OrderDateCreated;
            }
            set
            {
                _OrderDateCreated = value;
            }
        }
        public int OrderActive
        {
            get
            {
                return _OrderActive;
            }
            set
            {
                _OrderActive = value;
            }
        }
    }
}
