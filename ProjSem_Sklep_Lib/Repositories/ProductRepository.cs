using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjSem_Sklep_Lib.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Product> GetAll()
        {
            return _dbSet.Include(x => x.Orders).ToList();
        }
    }



    public class RepositoryHolder
    {
        private readonly AccRepository _accRepo;
        private readonly TeaRepository _teaRepo;
        private readonly StudRepository _studRepo;
        private readonly GruRepository _gruRepo;
        private readonly GruStudRepository _gruStudRepo;
        private readonly GruTeaRepository _gruTeaRepo;

        public AccRepository AccRepo => _accRepo;

        public TeaRepository TeaRepo => _teaRepo;

        public StudRepository StudRepo => _studRepo;

        public GruRepository GruRepo => _gruRepo;


        public GruStudRepository GruStudRepo => _gruStudRepo;

        public GruTeaRepository GruTeaRepo => _gruTeaRepo;

        public RepoPack(AccRepository accRepo,
                        TeaRepository teaRepo,
                        StudRepository studRepo,
                        GruRepository gruRepo,
                          GruStudRepository gruStudRepo,
                           GruTeaRepository gruTeaRepo)
        {
            _accRepo = accRepo;
            _teaRepo = teaRepo;
            _studRepo = studRepo;
            _gruRepo = gruRepo;
            _gruStudRepo = gruStudRepo;
            _gruTeaRepo = gruTeaRepo;
        }
    }
}
