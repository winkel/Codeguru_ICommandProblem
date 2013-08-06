using System.Collections.ObjectModel;
using System.Linq;
using Codeguru_ICommandProblem.Models;

namespace Codeguru_ICommandProblem.ViewModels
{
    class ListaKategoriiViewModel
    {
        public ListaKategoriiViewModel()
        {
            var kategoria = ListaKategorii.NowaLista();
            Produkty = new ObservableCollection<KategoriaViewModel>(
                (from k in kategoria select TransalteToViewModel(k))
                .ToArray());
        }

        private KategoriaViewModel TransalteToViewModel(Kategoria model)
        {
            return new KategoriaViewModel(model);
        }

        public ObservableCollection<KategoriaViewModel> Produkty { get; private set; }
    }
}
