﻿using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class SmallShopData
    {
        private List<Customer> customers = new List<Customer>();
        private List<Cart> carts = new List<Cart>();
        private List<Product> products = new List<Product>();
        private List<State> states = new List<State>();
        private List<Event> events = new List<Event>();
        public SmallShopData () { }

        public void Add_Good_To_Cart(String name, int amount, int value)
        {
            carts[value].Add_To_Cart(name, amount);
        }

        public void Add_Customer(String fname, String lname, String customer_id)
        {
            Customer new_customer = new Customer(fname, lname, customer_id);
            this.customers.Add(new_customer);

            Cart new_cart = new Cart();
            this.carts.Add(new_cart);
        }

        //created only for the sake of tests
        public int Get_Number_Of_Customer()
        {
            return this.customers.Count;
        }

        public int Get_Price(int value)
        {
            return products[value].Get_Price();
        }

        public void Add_Product(String name, int price)
        {
            Data.Product new_product = new Data.Product(name, price);
            this.products.Add(new_product);
        }

        public int Get_Good_Id(String name)
        {
            for(int i = 0; i<products.Count; i++)
            {
                if(products[i].Get_Product_Name() == name)
                {
                    return i;
                }
            }
            return -1;
        }

        //method to change a bit
        public void Change_Product_Amount(String name, int value, int sign)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Get_Product_Name() == name)
                {
                    this.states[i].Change_Amount(sign*value);
                }
            }
        }

        public int Get_Product_Amount(int value)
        {
            return states[value].Get_Amount();
        }

        public void Add_State(int value, bool state)
        {
            State new_state = new State(value, state);
            this.states.Add(new_state);
        } 

    }
}