//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp.BTslot5
//{
//    internal class Test
//    {
//        static void Main(string[] args)
//        {
//           var phoneBook = new PhoneBook();

//            phoneBook.InsertPhone("alice","0123456789"); 
//            phoneBook.InsertPhone("toro","0987654321"); 
//            phoneBook.InsertPhone("tulen", "6578900987"); 
//            phoneBook.InsertPhone("vanheo", "9873465034");

//            phoneBook.RemovePhone("tulen");

//            phoneBook.UpdatePhone("alice", "33333333333");

//            phoneBook.SearchPhone("alice"); 
//            phoneBook.SearchPhone("toro"); 
//            phoneBook.SearchPhone("vanheo");

//            phoneBook.Sort();

//            foreach (var item in phoneBook.PhoneList) {
//                Console.WriteLine("Name:{0},PHone:{1}", item.name, item.phone);
            
//            }
//        }
//    }
//}
