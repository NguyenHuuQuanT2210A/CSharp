//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp.BTslot5
//{
//    public class PhoneBook : Phone
//    {
//        public List<(string name, string phone)> PhoneList;
//        public PhoneBook()
//        {
//            PhoneList = new List<(string name, string phone)>();
//        }

//        public override void InsertPhone(string name, string phone)
//        {
//            var index = PhoneList.FindIndex(x => x.name == name);

//            if (index == -1)
//            {
//                PhoneList.Add((name, phone));
//            }
//            else
//            {
//                if (PhoneList[index].phone != phone)
//                {
//                    PhoneList[index] = (name, PhoneList[index].phone + "," + phone);
//                }
//            }
//        }

//        public override void RemovePhone(string name)
//        {
//            var index = PhoneList.FindIndex(x => x.name == name);

//            if (index != -1)
//            {
//                PhoneList.RemoveAt(index);
//            }
//        }

//        public override void UpdatePhone(string name, string newphone)
//        {
//            var index = PhoneList.FindIndex(x => x.name == name);

//            if (index != -1)
//            {
//                PhoneList[index] = (name, newphone);
//            }
//        }

//        public override void SearchPhone(string name)
//        {
//            var index = PhoneList.FindIndex(x => x.name == name);

//            if (index != -1)
//            {
//                Console.WriteLine("Name: {0}", PhoneList[index].name);
//                Console.WriteLine("Phone: {0}", PhoneList[index].phone);
//            }
//            else
//            {
//                Console.WriteLine("Not found");
//            }
//        }

//        public override void Sort()
//        {
//            PhoneList.Sort((x, y) => x.name.CompareTo(y.name));
//        }
//    }
//}
