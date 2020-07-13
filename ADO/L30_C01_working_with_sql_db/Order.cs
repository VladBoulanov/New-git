using System;
using System.Collections.Generic;
using System.Text;

namespace L30_C01_working_with_sql_db
{
    public class Order
    {
        public int Id { get; }

        public string Customer { get; }

        public DateTimeOffset OrderDate { get; }

        public float Discount { get; }

        public int Total { get; }

        public Order(int id,string customer, DateTimeOffset orderDate, float discount, int total)
        {
            Id = id;
            Customer = customer;
            OrderDate = orderDate;
            Discount = discount;
            Total = total;
        }
    }
}
