using System.Collections.Generic;
using WcfService.Entities;
using WcfService.Interfaces;
using WcfService.Repository;

namespace WcfService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class ServerService : IServer
	{
		private readonly IRepository _repository;

		public ServerService()
		{
			_repository = new InMemoryRepository();
		}

		public List<Document> GetDocuments()
		{
			return _repository.GetDocuments();
		}
	}
}
