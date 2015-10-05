using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace infs3204_prac03
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookStore" in both code and config file together.
    [ServiceContract]
    public interface IBookStore
    {
        [OperationContract]
        Book[] GetAllBooks();

        [OperationContract]
        bool AddBook(string ID, string name, string author, int year, float price, int stock);

        [OperationContract]
        bool DeleteBook(string field, string value);

        [OperationContract]
        Book[] SearchBook(string field, string value);
    }

    [DataContract]
    public class Book
    {
        [DataMember]
        public string ID;

        [DataMember]
        public string name;

        [DataMember]
        public string author;

        [DataMember]
        public int year;

        [DataMember]
        public float price;

        [DataMember]
        public int stock;

        public Book(string[] data)
        {
            ID = data[0];
            name = data[1];
            author = data[2];
            year = int.Parse(data[3]);
            price = float.Parse(data[4].Substring(1));
            stock = int.Parse(data[5]);
        }
    }
}
