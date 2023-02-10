using System;
using System.Collections.Generic;
using WcfService.Entities;
using WcfService.Interfaces;

namespace WcfService.Repository
{
	public class InMemoryRepository : IRepository
	{
		public List<Document> GetDocuments()
		{
			return new List<Document>
			{
				new Document
				{
					Id = 1,
					Number = "0001",
					Date = new DateTime(2020, 01, 01),
					LastUpdateDate = new DateTime(2021, 01, 01),
				},
				new Document
				{
					Id = 2,
					Number = "0002",
					Date = new DateTime(2021, 01, 01),
					LastUpdateDate = new DateTime(2022, 01, 01),
				},
				new Document
				{
					Id = 3,
					Number = "0003",
					Date = new DateTime(2022, 01, 01),
					LastUpdateDate = new DateTime(2023, 01, 01),
				},
				new Document
				{
					Id = 4,
					Number = "0004",
					Date = new DateTime(2023, 02, 01),
					LastUpdateDate = new DateTime(2023, 02, 01),
				},
				new Document
				{
					Id = 5,
					Number = "0005",
					Date = new DateTime(2023, 02, 01),
					LastUpdateDate = new DateTime(2023, 02, 01),
				},
				new Document
				{
					Id = 6,
					Number = "0006",
					Date = new DateTime(2023, 02, 01),
					LastUpdateDate = new DateTime(2023, 02, 01),
				},
				new Document
				{
					Id = 7,
					Number = "0007",
					Date = new DateTime(2023, 02, 01),
					LastUpdateDate = new DateTime(2023, 02, 01),
				}
			};
		}
	}
}