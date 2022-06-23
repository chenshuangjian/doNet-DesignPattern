using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 步骤 5 创建一个 Meal 类，带有上面定义的 Item 对象。
    /// 进餐
    /// </summary>
    public class Meal
    {
        private List<Item> items = new List<Item>();
        public void addItem(Item item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine("Item : " + item.name());
                Console.WriteLine(", Packing : " + item.packing().pack());
                Console.WriteLine(", Price : " + item.price());
            }
        }
    }
}
