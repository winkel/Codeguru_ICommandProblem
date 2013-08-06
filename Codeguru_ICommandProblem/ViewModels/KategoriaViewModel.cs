using Codeguru_ICommandProblem.Common;
using Codeguru_ICommandProblem.Models;
using System;
using System.Windows.Input;

namespace Codeguru_ICommandProblem.ViewModels
{
    class KategoriaViewModel
    {
        private Kategoria _model;

        public KategoriaViewModel(Kategoria model)
        {
            if (model == null) throw new ArgumentNullException("model");

            _model = model;

            this.DelegateKategorieCommand = new DelegateCommand(HelloAction, HelloCanExecute);
        }

        public string Nazwa { get { return _model.Nazwa; } }

        public ICommand DelegateKategorieCommand { get; private set; }

        private bool HelloCanExecute(object obj)
        {
            return true;
        }

        private void HelloAction(object obj)
        {
            System.Diagnostics.Debug.WriteLine(String.Format("Działam dla '{0}'" , Nazwa));
        }
    }
}
