using System.Collections.Generic;
using WcfService.Entities;

namespace WcfService.Interfaces
{
	internal interface IRepository
	{
		List<Document> GetDocuments();
	}
}
