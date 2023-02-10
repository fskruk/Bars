using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WcfService.Entities;
using WpfApp.ServiceReference;

namespace WpfApp.ViewModel
{
    internal class DocumentsViewModel : INotifyPropertyChanged
	{
        private readonly ServerClient _client;
		private Document selectedDocument;

		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<Document> Documents { get; set; }

		public Document SelectedDocument
		{
			get { return selectedDocument; }
			set
			{
				selectedDocument = value;
				OnPropertyChanged("SelectedDocument");
			}
		}

		public DocumentsViewModel()
		{
			_client = new ServerClient();

			Documents = new ObservableCollection<Document>(_client.GetDocuments());
			_client.Close();
		}

		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}
