﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderService_Ui
{

  /// <summary>
  /// OrderDetail class : a entry of an order object
  /// to record the goods and its quantity
  /// </summary>
  public class OrderDetail {

    /// <summary>
    /// OrderDetail constructor
    /// </summary>
    /// <param name="id">orderDetail's id</param>
    /// <param name="goods">orderDetail's goods</param>
    /// <param name="quantity">goods quantity</param>
    public OrderDetail(string id, Goods goods, uint quantity) {
      this.Id = id;
      this.Goods = goods;
      this.Quantity = quantity;
    }
    public OrderDetail()
        {

        }
        /// <summary>
        /// OrderDetail's id
        /// </summary>
        public string CustomerName { get; set; }
        public void setCustomerName(string customerName)
        {
            this.CustomerName = customerName;
        }
        
        public string Id { get; set; }
    public Goods Goods { get; set; }
    public uint Quantity { get; set; }

    public override bool Equals(object obj) {
      var detail = obj as OrderDetail;
      return detail != null &&
             Goods.Id == detail.Goods.Id &&
             Quantity == detail.Quantity;
    }

    public override int GetHashCode() {
      var hashCode = 1522631281;
      hashCode = hashCode * -1521134295 + Goods.Name.GetHashCode();
      hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
      return hashCode;
    }

    /// <summary>
    /// override ToString
    /// </summary>
    /// <returns>string:message of the OrderDetail object</returns>
    public override string ToString() {
      string result = "";
      result += $"orderDetailId:{Id}:  ";
      result += Goods + $", quantity:{Quantity}";
      return result;
    }


  }
}
