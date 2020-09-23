using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation
{
    public class StockManager
    {
        List<Perfume> listProducts;

        public StockManager()
        {
            this.listProducts = new List<Perfume>();
        }

        public void AddPerfume(Perfume m)
        {
            //if(listProducts.Count == 0)
            //{
            //    listProducts.Add(m);
            //    m.Quantity++;
            //    return;
            //}


            //foreach (var product in listProducts)
            //{
            //    if (product.Name.Equals(m.Name))
            //    {
            //        m.Quantity++;
            //    }
            //    else
            //    {
            //        listProducts.Add(m);
            //        m.Quantity++;
            //    }
            //}

            var perfumeToBeFound = listProducts.FirstOrDefault(x => x.Name.Equals(m.Name));
            if (perfumeToBeFound != null)
            {
                perfumeToBeFound.Quantity++;
            }
            else
            {
                listProducts.Add(m);
                m.Quantity++;
            }



        }

        public void DeletePerfume(Perfume m)
        {
            var perfumeToBeFound = listProducts.FirstOrDefault(x => x.Name.Equals(m.Name));
            if (perfumeToBeFound != null && perfumeToBeFound.Quantity > 1)
            {
                perfumeToBeFound.Quantity--;
            } else if (perfumeToBeFound != null && perfumeToBeFound.Quantity == 1)
            {
                listProducts.Remove(perfumeToBeFound);
            }
            else
            {
                throw new Exception("Perfume not found.");
            }

        }

        public bool IsPerfumeInStock(string name)
        {
            var perfumeToBeFound = listProducts.FirstOrDefault(x => x.Name.Equals(name));
            return perfumeToBeFound != null;

        }

    }
}
