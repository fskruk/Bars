using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Entities
{
	public class Document
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public string Number { get; set; }

		public DateTime LastUpdateDate { get; set; }
	}
}