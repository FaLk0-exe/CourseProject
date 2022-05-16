using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public static class ERMRepository
    {
        static VP vp=new VP();
        public static List<dynamic> GetDynamicOrders()=>
            vp.customer_order.Where(or => or.order_status.name != "Відхилено" &&
            or.order_status.name!= "Отримано").
            Select(c => new
                {
                    OrderCode = c.id,
                    CustomerPhone=c.customer.phone_number,
                    OperationTime = c.operation_time,
                    OrderStatus=c.order_status.name
                }).ToList<dynamic>();

        public static customer_order GetOrderByCode(int code) =>
            vp.customer_order.FirstOrDefault(c => c.id == code);

        public static bool SetOrderStatus(customer_order order,int statusId)
        {
            try
            {
                order.order_status_id = statusId;
                vp.Entry(order).State = System.Data.Entity.EntityState.Modified;
                vp.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<order_details> GetOrderListByOrderCode(int code) =>
            vp.customer_order.First(o=>o.id==code).order_details.ToList();

        public static void AddElementToOrder(customer_order order,int productId)
        {
            
            vp.order_details.Add(new order_details
            {
                customer_order_id = order.id,
                product_id = productId,
                product_amount = 1
            });
            vp.SaveChanges();
        }

        public static List<string> GetCategoryNames()
        {
            return vp.product_category.Select(p => p.name).ToList();
        }

        public static List<order_status> GetStatuses()
        {
            return vp.order_status.Select(p => p).ToList();
        }

        public static List<string> GetManufacturers()
        {
            return vp.manufacturer.Select(p => p.name).ToList();
        }

        public static List<product_amount> GetFullProducts(customer_order order)
        {
            var a = vp.customer_order.First(c => c.id == order.id).order_details.ToList();
            return vp.product_amount.ToList().Where(p=>
            a.All
            (o=>o.product.name!=p.product.name)).
            Select(p => p).ToList();
        }

        public static void EditCustomer(customer c)
        {
            vp.Entry(c).State = System.Data.Entity.EntityState.Modified;
            vp.SaveChanges();
        }

        public static product_amount GetProductByName(string name)
        {
            return vp.product_amount.First(p => p.product.name == name);
        }

        public static void ChangeOrderDetailValueAmount(order_details orderDetail, int value)
        {
            orderDetail.product_amount += value;
            vp.Entry(orderDetail).State = System.Data.Entity.EntityState.Modified;
            vp.SaveChanges();
        }

        public static void RemoveElementFromOrder(order_details orderDetail)
        {
            vp.Entry(orderDetail).State = System.Data.Entity.EntityState.Deleted;
            vp.SaveChanges();
        }

    }
}
