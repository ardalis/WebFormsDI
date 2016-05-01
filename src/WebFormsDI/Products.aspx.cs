using System;
using WebFormsDI.Models;

namespace WebFormsDI
{
    public partial class Products : BasePage
    {
        public IProductRepository ProductRepository { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var products = ProductRepository.List();
            this.ProductRepeater.DataSource = products;
            this.ProductRepeater.DataBind();
        }
    }
}