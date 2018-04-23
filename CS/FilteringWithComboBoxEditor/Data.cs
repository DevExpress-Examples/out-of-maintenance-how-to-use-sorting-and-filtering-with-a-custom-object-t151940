using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilteringWithComboBoxEditor
{
    public class Data
    {
        public static List<Element> DataList
        {
            get
            {
                List<Element> list = new List<Element>(
                  new Element[]
                {
                    new Element(){Name="elem1",Value=new ElementItem(){ItemId=0,ItemName="alfa"}},
                    new Element(){Name="elem2",Value=new ElementItem(){ItemId=0,ItemName="beta"}},
                    new Element(){Name="elem3",Value=new ElementItem(){ItemId=0,ItemName="gamma"}},
                    new Element(){Name="elem4",Value=new ElementItem(){ItemId=0,ItemName="omega"}},
                    new Element(){Name="elem5",Value=new ElementItem(){ItemId=0,ItemName="lambda"}},
                    new Element(){Name="elem6",Value=new ElementItem(){ItemId=0,ItemName="fi"}},
                    new Element(){Name="elem7",Value=new ElementItem(){ItemId=0,ItemName="xi"}},
                    new Element(){Name="elem8",Value=new ElementItem(){ItemId=0,ItemName="pi"}},
                    new Element(){Name="elem9",Value=new ElementItem(){ItemId=0,ItemName="ro"}},
                    new Element(){Name="elem0",Value=new ElementItem(){ItemId=0,ItemName="sigma"}}
                });
                foreach (var elem in list)
                {
                    List<ElementItem> avaliableValues = new List<ElementItem>();
                    avaliableValues.Add(elem.Value);
                    for (int i = 0; i < 5; i++)
                        avaliableValues.Add(new ElementItem() { ItemName = elem.Value.ItemName + i, ItemId = i });
                    elem.AvaliableValues = avaliableValues;
                }

                return list;
            }
        }
    }

    public class Element
    {
        public string Name { get; set; }
        public ElementItem Value { get; set; }
        public List<ElementItem> AvaliableValues { get; set; }
    }

    public class ElementItem
    {
        public string ItemName { get; set; }
        public int ItemId { get; set; }
    }

}
