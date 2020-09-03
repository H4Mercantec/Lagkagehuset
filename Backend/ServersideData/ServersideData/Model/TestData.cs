using System;
using System.Collections.Generic;
using System.Text;

namespace ServersideData.Model
{
    public class TestData
    {
        public List<Code> codes;
        public List<Customer> customers;
        public List<Inventory> inventories;
        public List<Order> orders;
        public List<Product> products;
        public List<Shop> shops;

        public TestData()
        {
            this.codes = new List<Code>();
            this.customers = new List<Customer>();
            this.inventories = new List<Inventory>();
            this.orders = new List<Order>();
            this.products = new List<Product>();
            this.shops = new List<Shop>();
            GenerateData();
        }
        private void GenerateData()
        {
            string[] brod = { "Almindelige Rundstykker", "Franske horn", "Giffel", "Håndværker", "Kernebidder", "Majsstykke", "Søstjerne", "Trekorns" };
            int i = 0;
            while (i < brod.Length)
            {
                products.Add(new Product(i+1, brod[0]));
            }
            string[] adress = { "Amager Strandvej 112", "Amagerbrogade 148", "Vermlandsgade 51", "Bagsværd Hovedgade 128", "Passagerterminalen 10" };
            string[] city = { "København S", "København S", "København S", "Bagsværd", "Billund" };
            string[] postcode = { "2300", "2300", "2300", "2880", "7190" };
            string[] phonenumber = { "70705025", "79304341", "79304570", "73709407", "29695486" };
            i = 0;
            while (i < adress.Length)
            {
                shops.Add(new Shop(i + 1, adress[i], city[i], postcode[i], phonenumber[i]));
            }
            int[] shopid = { 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5 };
            int[] proid = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 4, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 2, 3, 5, 6, 7, 8, 1, 2, 3 };
            int[] amount = { 120, 4, 6, 11, 25, 2, 4, 12, 34, 5, 6, 2, 1, 120, 4, 6, 11, 25, 2, 4, 12, 5, 12, 8, 9, 5, 2, 1, 1, 1 };
            i = 0;
            while (i < shopid.Length)
            {
                inventories.Add(new Inventory(i + 1, shopid[i], proid[i], amount[i]));
            }

        }
    }
}
