//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ShopCet47I.Web.Data.Entities
//{
//    public class Product
//    {
//    } // end class Product
//} // namespace ShopCet47I.Web.Data.Entities



//----------------------
// Ficheiro: Products.cs
//----------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // à conta do delta1
using System.Linq;
using System.Threading.Tasks;

//--------------------------------------------
// 6F dia 4 de Setembro de 2020 Raphael Santos
//--------------------------------------------
// Refeito no dia 10 de Setembro 5f
//--------------------------------------------

namespace ShopCet47I.Web.Data.Entities
{ // anotaçoes
    public class Product
    { // modelo especial que representa a tabela
        public int Id { get; set; }

        public string Name { get; set; }

        // anotação delta1:
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")] // 20.18 -- > é o titulo das labels
        public DateTime LastSale { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

    } // end class Product


} // end namespace ShopCet47I.Web.Data.Entities
