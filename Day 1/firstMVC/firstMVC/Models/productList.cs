namespace firstMVC.Models
{
    public class productList
    {
        #region Properties
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public double productPrice { get; set; }
        public bool productIsInStock { get; set; }
        #endregion

        #region Data
        static List<productList> pList = new List<productList>()
        {
            new productList(){ productId=101, productName="Iphone", productCategory="Electronics", productIsInStock=true, productPrice=150000},
            new productList(){ productId=102, productName="Pepsi", productCategory="Cold-Drink", productIsInStock=true, productPrice=80},
            new productList(){ productId=103, productName="Latte", productCategory="Coffee", productIsInStock=false, productPrice=250},
            new productList(){ productId=104, productName="Maggie", productCategory="Fast-Food", productIsInStock=true, productPrice=160},
            new productList(){ productId=105, productName="Air-Pods", productCategory="Electronics", productIsInStock=true, productPrice=26000},
            new productList(){ productId=106, productName="Nike Air", productCategory="Sports", productIsInStock=false, productPrice=18000},
            new productList(){ productId=107, productName="Adidas T", productCategory="Sports", productIsInStock=true, productPrice=3450},
        };
        #endregion

        #region Methods
        public List<productList> GetAllProducts()
        {
            return pList;
        }
        #endregion

    }
}
