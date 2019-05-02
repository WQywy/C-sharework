using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Order
{
    
    [Serializable]
    public class Goods
    {
        [Key]
        public string GoodsName { get; set; }
        public int GoodsAmount { get; set; }
        public float GoodsPrice { get; set; }
        private Goods()
        {
        }
        public Goods(string goodsName, int goodsAmount, float goodsprice)
        {
            this.GoodsName = goodsName;
            this.GoodsAmount = goodsAmount;
            this.GoodsPrice = goodsprice;
        }
        public override bool Equals(object obj)
        {
            if (obj is Goods)
            {
                Goods g = (Goods)obj;
                if (g.GoodsName == GoodsName && g.GoodsAmount == GoodsAmount && g.GoodsPrice == GoodsPrice)
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
