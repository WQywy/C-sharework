using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
  /// <summary>
  /// OrderService:provide ordering service,
  /// like add order, remove order, query order and so on
  /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
  /// </summary>
  class OrderService {

    private List<Order> orderList;
    
    public OrderService() {
      orderList = new List<Order>();
    }

   
    /// add new order
    public void AddOrder(Order order) {
     
      foreach (Order o in orderList) {
        if (o.Id.Equals(order.Id)) {
          throw new Exception($"order-{order.Id} is already existed!");
        }
      }
      orderList.Add(order);
      
    }

    
    /// query by orderId
    public Order GetById(uint orderId) {
      foreach (Order o in orderList) {
        if (o.Id == orderId) { return o; } 
      }
      return null;
    }

 
    /// remove order  
    public void RemoveOrder(uint orderId) {
      Order order = GetById(orderId);
      if (order == null) return;
      orderList.Remove(order);
    }

 
    /// query all orders
    public List<Order> QueryAllOrders() {
      return orderList;
    }

   
    
    public List<Order> QueryByGoodsName(string goodsName) {
      
            

            var result = from ordergoods in orderList
                                 where ordergoods.Containgoods(goodsName) select ordergoods;         
      return result.ToList();
    }

    
    public List<Order> QueryByCustomerName(string customerName) {
      var query = orderList
          .Where(order => order.Customer.Name == customerName);
      return query.ToList();
    }

  }
}
