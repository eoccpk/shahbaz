namespace e_commerce_web.models
{


        public partial class Product
        {
           
            public int Id { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public Nullable<int> UnitPrice { get; set; }
            public string StockQuantity { get; set; }
            public Nullable<int> Rating { get; set; }
            public string Seller { get; set; }
            public string Image { get; set; }
            public DateTime date { get; set; }

       
        }
    }


