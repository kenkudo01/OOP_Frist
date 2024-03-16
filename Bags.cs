namespace Bag
{
    public class Item
    {
        public int Element;
        public int Frequency;

        public Item(int e, int f)
        {
            Element = e;
            Frequency = f;
        }

        public override string ToString()
        {
            return "(" + Element.ToString() + "," + Frequency.ToString() + ")";
        }

    }

    public class Bags
    {
        private List<Item> seq = new List<Item>();

        public List<Item> getSeq()
        {
            return seq;
        }
        /*
        public bool isin(int a)
        {
            return seq.Element.Contains(a);
        }
        */
        public bool isin(int a)
        {
            return seq.Any(item => item.Element == a);
        }

        /*
        public void Insert(int a)
        {
            if(isin(a))
            {
                int ind = seq.Element.IndexOf(a);
                seq[ind].Frequency += 1;
            }
            else
            {
                seq.Add(new Item(a, 1));
            }
        }
        */
        public void Insert(int a)
        {
            var item = seq.FirstOrDefault(i => i.Element == a);
            if (item != null)
            {
                item.Frequency += 1;
            }
            else
            {
                seq.Add(new Item(a, 1));
            }
        }

        /*
        public void RemoveList(int a)
        {
            int ind = seq.Element.IndexOf(a);
            int num = seq[ind].Frequency;
            if (num <= 0)
            {
                seq.Remove(seq[ind]);
            }
            else
            {
                seq[ind].Frequency -= 1;
            }
        }
        */
        public void RemoveList(int a)
        {
            var item = seq.FirstOrDefault(i => i.Element == a);
            if (item != null && item.Frequency > 1)
            {
                item.Frequency -= 1;
            }
            else
            {
                seq.Remove(item);
            }
        }


        public int OnlyOne()
        {
            /*
            int num = 0;
            for(int i = 0; i < seq.Count(); i++)
            {
                if (seq[i].Frequency == 1)
                    num += 1;
            }
            */

            int n = seq.Count(x => x.Frequency == 1);

            return n;
        }

        public void Print()
        {
            foreach (Item e in seq)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}