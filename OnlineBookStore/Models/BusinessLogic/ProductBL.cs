using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.BusinessLogic
{
    public class ProductBL
    {
        private int _ProductID;
        private int _CategoryID;
        private int _PublisherID;
        private string _ProductCode;
        private string _ProductImage;
        private string _ProductName;
        private float _ProductPrice1;
        private float _ProductPrice2;
        private int _ProductStock;
        private string _ProductAuthor;
        private DateTime _ProductReleaseDate;
        private string _ProductVersion;
        private string _ProductDescription;
        private string _ProductDetails;
        private int _ProductView;
        private int _ProductOrderBuy;
        private int _ProductStatus;
        private DateTime _ProductDateCreated;
        private DateTime _ProductDateUpdated;        
        private int _ProductActive;

        public ProductBL()
        {
            
        }

        // Insert new Product Constructor in Admin module
        public ProductBL(int ProductID_, 
                         int CategoryID_, 
                         int PublisherID_,
                         string ProductCode_, 
                         string ProductImage_, 
                         string ProductName_, 
                         float ProductPrice1_, 
                         float ProductPrice2_,
                         int ProductStock_, 
                         string ProductAuthor_, 
                         DateTime ProductReleaseDate_, 
                         string ProductVersion_, 
                         int ProductStatus_, 
                         string ProductDescription_,
                         string ProductDetails_, 
                         int ProductView_, 
                         int ProductOrderBuy_,
                         DateTime ProductDateCreated_,
                         DateTime ProductDateUpdated_,  
                         int ProductActive_)
        {
            _ProductID = ProductID_;
            _CategoryID = CategoryID_;
            _PublisherID = PublisherID_;
            _ProductCode = ProductCode_;
            _ProductName = ProductName_;
            _ProductPrice1 = ProductPrice1_;
            _ProductPrice2 = ProductPrice2_;
            _ProductDescription = ProductDescription_;
            _ProductDetails = ProductDetails_;
            _ProductStock = ProductStock_;
            _ProductAuthor = ProductAuthor_;
            _ProductReleaseDate = ProductReleaseDate_;
            _ProductVersion = ProductVersion_;
            _ProductView = ProductView_;
            _ProductOrderBuy = ProductOrderBuy_;
            _ProductStatus = ProductStatus_;
            _ProductDateCreated = ProductDateCreated_;
            _ProductDateUpdated = ProductDateUpdated_;
            _ProductActive = ProductActive_;
        }

        public ProductBL(int CategoryID_, 
                         int PublisherID_,
                         string ProductCode_, 
                         string ProductImage_, 
                         string ProductName_, 
                         float ProductPrice1_, 
                         float ProductPrice2_,
                         int ProductStock_, 
                         string ProductAuthor_,                          
                         DateTime ProductReleaseDate_, 
                         string ProductVersion_, 
                         int ProductStatus_, 
                         string ProductDescription_,
                         string ProductDetails_, 
                         int ProductView_, 
                         int ProductOrderBuy_,
                         DateTime ProductDateCreated_,
                         DateTime ProductDateUpdated_, 
                         int ProductActive_)
        {
            _CategoryID = CategoryID_;
            _PublisherID = PublisherID_;
            _ProductCode = ProductCode_;
            _ProductImage = ProductImage_;
            _ProductName = ProductName_;
            _ProductPrice1 = ProductPrice1_;
            _ProductPrice2 = ProductPrice2_;
            _ProductStock = ProductStock_;
            _ProductAuthor = ProductAuthor_;
            _ProductReleaseDate = ProductReleaseDate_;
            _ProductVersion = ProductVersion_;
            _ProductStatus = ProductStatus_;
            _ProductDescription = ProductDescription_;
            _ProductDetails = ProductDetails_;
            _ProductOrderBuy = ProductOrderBuy_;
            _ProductStatus = ProductStatus_;
            _ProductDateCreated = ProductDateCreated_;
            _ProductDateUpdated = ProductDateUpdated_;
            _ProductActive = ProductActive_;
        }

        public ProductBL(int ProductID_, int ProductView_)
        {
            _ProductID = ProductID_;
            _ProductView = ProductView_;
        }
        public ProductBL(int ProductID_)
        {
            _ProductID = ProductID_;
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

        public int PublisherID
        {
            get
            {
                return _PublisherID;
            }
            set
            {
                _PublisherID = value;
            }
        }
        public string ProductCode
        {
            get
            {
                return _ProductCode;
            }
            set
            {
                _ProductCode = value;
            }
        }

        public string ProductImage
        {
            get
            {
                return _ProductImage;
            }
            set
            {
                _ProductImage = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                _ProductName = value;
            }
        }

        public float ProductPrice1
        {
            get
            {
                return _ProductPrice1;
            }
            set
            {
                _ProductPrice1 = value;
            }
        }

        public float ProductPrice2
        {
            get
            {
                return _ProductPrice2;
            }
            set
            {
                _ProductPrice2 = value;
            }
        }


        public int ProductStock
        {
            get
            {
                return _ProductStock;
            }
            set
            {
                _ProductStock = value;
            }
        }

        public string ProductAuthor
        {
            get
            {
                return _ProductAuthor;
            }
            set
            {
                _ProductAuthor = value;
            }
        }


        public DateTime ProductReleaseDate
        {
            get
            {
                return _ProductReleaseDate;
            }
            set
            {
                _ProductReleaseDate = value;
            }
        }

        public string ProductVersion
        {
            get
            {
                return _ProductVersion;
            }
            set
            {
                _ProductVersion = value;
            }
        }

        public string ProductDescription
        {
            get
            {
                return _ProductDescription;
            }
            set
            {
                _ProductDescription = value;
            }
        }

        public string ProductDetails
        {
            get
            {
                return _ProductDetails;
            }
            set
            {
                _ProductDetails = value;
            }
        }

        public int ProductView
        {
            get
            {
                return _ProductView;
            }
            set
            {
                _ProductView = value;
            }
        }

        public int ProductOrderBuy
        {
            get
            {
                return _ProductOrderBuy;
            }
            set
            {
                _ProductOrderBuy = value;
            }
        }
        public int ProductStatus
        {
            get
            {
                return _ProductStatus;
            }
            set
            {
                _ProductStatus = value;
            }
        }

        public DateTime ProductDateUpdated
        {
            get
            {
                return _ProductDateUpdated;
            }
            set
            {
                _ProductDateUpdated = value;
            }
        }

        public DateTime ProductDateCreated
        {
            get
            {
                return _ProductDateCreated;
            }
            set
            {
                _ProductDateCreated = value;
            }
        }

        public int ProductActive
        {
            get
            {
                return _ProductActive;
            }
            set
            {
                _ProductActive = value;
            }
        }
    }
}
