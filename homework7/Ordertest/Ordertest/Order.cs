using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ordertest {

    /// <summary>
    /// Order class : all orderDetails
    /// to record each goods and its quantity in this ordering
    /// </summary>
    
    [Serializable]
    public class Order : IComparable
    {

        private List<OrderDetail> details=new List<OrderDetail>();

        /// <summary>
        /// Order constructor
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <param name="customer">who orders goods</param>
        public Order()
        {

        }

        public Order(uint orderId, Customer customer) {
            Id = orderId;
            Customer = customer;
            money = 0;
        }

        /// <summary>
        /// order id
        /// </summary>
        public uint Id { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> Details {
            get =>this.details; }
        public double money { get; set; }
        /// <summary>
        /// add new orderDetail to order
        /// </summary>
        /// <param name="orderDetail">the new orderDetail which will be added</param>
        public void AddDetails(OrderDetail orderDetail) {
            if (this.Details.Contains(orderDetail))  {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            money += orderDetail.Quantity * orderDetail.Goods.Price;
            details.Add(orderDetail);
        }

        /// <summary>
        /// remove orderDetail by orderDetailId from order
        /// </summary>
        /// <param name="orderDetailId">id of the orderDetail which will be removed</param>
        public void RemoveDetails(uint orderDetailId) {
            details.RemoveAll(d =>d.Id==orderDetailId);
        }
/*
        public bool Containgoods(string goodname)
        {
            var goods = from details;
            return false;
        }
        */
        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Order object</returns>
        public override string ToString() {
            String result = $"orderId:{Id}, customer:({Customer})";
            details.ForEach(detail => result += "\n\t" + detail);
            result += "\n\tTotale money:" + money + "\n";
            return result;
        }

        public bool Containgoods(string goodsname)
        {
            var result = from detail in details
                         where detail.Goods.Name == goodsname select detail;
            if(result.FirstOrDefault() != null) { return true; }
            return false;
        }

        public int CompareTo(object obj)
        {
            //实现接口方法一：
            if (obj == null) return 1;
            Order otherorder = obj as Order;
            if (Id > otherorder.Id) { return 1; }
            else
            {
                if (Id == otherorder.Id) { return 0; }
                else { return -1; }
            }
        }
    }
}
