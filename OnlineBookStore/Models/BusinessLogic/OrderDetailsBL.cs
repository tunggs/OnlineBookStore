using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class OrderDetailsBL
    {
        private int _OrderDetailsID;
        private int _OrderID;
        private int _ProductID;
        private float _OrderPrice;
        private int _OrderQuantity;
        private float _OrderTotalPrice;

        public OrderDetailsBL()
        {

        }

        public OrderDetailsBL(int OrderDetailsID_, 
                              int OrderID_, 
                              int ProductID_, 
                              float OrderPrice_, 
                              int OrderQuantity_,
                              float OrderTotalPrice_)
        {
            _OrderDetailsID = OrderDetailsID_;
            _OrderID = OrderID_;
            _ProductID = ProductID_;
            _OrderPrice = OrderPrice_;
            _OrderQuantity = OrderQuantity_;
            _OrderTotalPrice = OrderTotalPrice_;
        }

        public OrderDetailsBL(int OrderID_, 
                              int ProductID_, 
                              float OrderPrice_, 
                              int OrderQuantity_, 
                              float OrderTotalPrice_)
        {
            _OrderID = OrderID_;
            _ProductID = ProductID_;
            _OrderPrice = OrderPrice_;
            _OrderQuantity = OrderQuantity_;
            _OrderTotalPrice = OrderTotalPrice_;
        }

        public OrderDetailsBL(int OrderDetailsID_, 
                              int OrderQuantity_, 
                              float OrderTotalPrice_)
        {
            _OrderDetailsID = OrderDetailsID_;
            _OrderQuantity = OrderQuantity_;
            _OrderTotalPrice = OrderTotalPrice_;
        }

        public OrderDetailsBL(int OrderDetailID_)
        {
            _OrderDetailsID = OrderDetailID_;
        }

        public int OrderDetailsID
        {
            get
            {
                return _OrderDetailsID;
            }
            set
            {
                _OrderDetailsID = value;
            }
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

        public int ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                _ProductID = value;
            }
        }

        public float OrderPrice
        {
            get
            {
                return _OrderPrice;
            }
            set
            {
                _OrderPrice = value;
            }
        }

        public int OrderQuantity
        {
            get
            {
                return _OrderQuantity;
            }
            set
            {
                _OrderQuantity = value;
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

    }
}
