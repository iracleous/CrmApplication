using CrmApplication.Model;
using CrmApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    public class LibraryService : ILibraryService
    {

        private readonly Repository<Book, int> _bookRepo;
        private readonly Repository<Member, int> _memberRepo;
        private readonly Repository<Lending, int> _lendingRepo;

        public LibraryService(Repository<Book, int> bookRepo, Repository<Member, int> memberRepo,
            Repository<Lending, int> lendingRepo)
        {
            _bookRepo = bookRepo;
            _memberRepo = memberRepo;
            _lendingRepo = lendingRepo;
        }   

        public void AddBook(Book book)
        {
            _bookRepo.Create(book);
            book.IsAvailable = true;
        }

        public void AddMember(Member member)
        {
           _memberRepo.Create(member);
        }

        public List<Book> BooksHadLent(int memberId)
        {
            throw new NotImplementedException();
        }

        public List<Book> BrowseBooks(List<string> keywords)
        {
            string author = keywords[0];
            return _bookRepo.Retreive().Where(book => book.Author==author).ToList();
        }

        public void LendBook(int memberId, int bookId)
        {
            var member = _memberRepo.Retreive(memberId);
            var book = _bookRepo.Retreive(bookId);
            if (book != null)
            {
                book.IsAvailable = false;
                var lending = new Lending { Member=member, Book=book , DateTime= DateTime.Now};
                _lendingRepo.Create(lending);
            }
               

        }

        public void ReturnBook(int memberId, int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
