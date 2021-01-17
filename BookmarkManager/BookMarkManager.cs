using System;
using System.Collections.Generic;
using System.Text;

namespace BookmarkManager
{
    public class BookMarkManager
    {
        List<BookMark> myBookMarks = new List<BookMark>();
        
        public void Menu()
        {
            RetriveListOfBookMarksFromUser();
        }

        
        private List<BookMark> RetriveListOfBookMarksFromUser()
        {
            for (int i = 0; i < 5; i++)
            {
                myBookMarks.Add(RetriveBookmarkFromUser());
            }

            return myBookMarks;
        }

        private BookMark RetriveBookmarkFromUser()
        {
            BookMark bookMark = new BookMark();
            Console.WriteLine("Name: ");
            bookMark.Name = Console.ReadLine();
            Console.WriteLine("URL: ");
            bookMark.URL = Console.ReadLine();
            return bookMark;
        }
    }
}
