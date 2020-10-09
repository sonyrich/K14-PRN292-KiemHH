using System;

namespace MyBookLibrary
{
    public class Book
    {
        public string mID;
        public string mTitle;
        public string mAuthor;
        public float mPrice;

        public Book()
        {

        }

        public Book(string ID, string Title, string Author, float Price)
        {
            this.mID = ID;
            this.mTitle = Title;
            this.mAuthor = Author;
            this.mPrice = Price;
        }

        public string ID
        {
            get { return mID; }
            set { mID = value; }
        }

        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }

        public string Author
        {
            get { return mAuthor; }
            set { mAuthor = value; }
        }

        public float Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public void ExtractInfo()
        {
            Console.WriteLine("ID: {0}\n" +
                              "Title: {1}\n" +
                              "Author: {2}\n" +
                              "Price: {3}\n" +
                              "-----_-----",
                              mID, mTitle, mAuthor, mPrice);
        }
    }
}
