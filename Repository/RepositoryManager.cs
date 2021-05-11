using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        //Repositories 
        private RepositoryContext _repositoryContext;
        private IOrganizationRepository _organizationRepository;
        private IUserRepository _userRepository;
   
    

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IOrganizationRepository Organization
        {
            get
            {
                if (_organizationRepository == null)
                    _organizationRepository = new OrganizationRepository(_repositoryContext);

                return _organizationRepository;
            }
        }

        //User
        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);

                return _userRepository;
            }
        }
        

        public void Save() => _repositoryContext.SaveChanges();
    }
}