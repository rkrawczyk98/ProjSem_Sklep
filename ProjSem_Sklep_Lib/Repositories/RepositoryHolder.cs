namespace ProjSem_Sklep_Lib.Repositories
{
    public class RepositoryHolder
    {
        private OrderRepository _ordRepo;
        private ProductRepository _prodRepo;
        private UserRepository _userRepo;
        private ProdOrdRepository _prodOrdRepo;

        public OrderRepository OrdRepo => _ordRepo;

        public ProductRepository ProdRepo => _prodRepo;

        public UserRepository UserRepo => _userRepo;

        public ProdOrdRepository ProdOrdRepo => _prodOrdRepo;


        public RepositoryHolder(OrderRepository ordRepo,
                                ProductRepository prodRepo,
                                UserRepository userRepo,
                                ProdOrdRepository prodOrdRepo)
        {
            _ordRepo = ordRepo;
            _prodRepo = prodRepo;
            _userRepo = userRepo;
            _prodOrdRepo = prodOrdRepo;
        }
    }
}
