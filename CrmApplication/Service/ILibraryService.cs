using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    public interface ILibraryService
    {
        public void LendBook(int memberId, int bookId);
        public void ReturnBook(int memberId, int bookId);

        public List<Book> BooksHadLent(int memberId);

        public List<Book> BrowseBooks(List<string> keywords);

        public void AddBook(Book book);
        public void AddMember(Member member);

    }
}
