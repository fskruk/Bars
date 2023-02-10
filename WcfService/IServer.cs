using System.Collections.Generic;
using System.ServiceModel;
using WcfService.Entities;

namespace WcfService
{
	[ServiceContract]
	public interface IServer
	{
		[OperationContract]
		List<Document> GetDocuments();
	}
}
