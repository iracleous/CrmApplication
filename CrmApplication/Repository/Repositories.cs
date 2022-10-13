using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Repository
{
    public class BookRepository : Repository<Book, int>
    {
        public BookRepository(List<Book> Ts) : base(Ts)
        {
        }

        private int counter;

        public override int IncreaseId()
        {
            return ++counter;
        }
    }


    public class MemberRepository : Repository<Member, int>
    {
        public MemberRepository(List<Member> Ts) : base(Ts)
        {
        }

        private int counter;

        public override int IncreaseId()
        {
            return ++counter;
        }
    }


    public class LendingRepository : Repository<Lending, int>
    {
        public LendingRepository(List<Lending> Ts) : base(Ts)
        {
        }

        private int counter;

        public override int IncreaseId()
        {
            return ++counter;
        }
    }



}
