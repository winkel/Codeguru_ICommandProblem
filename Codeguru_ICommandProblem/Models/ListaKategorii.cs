using System;
using System.Collections.Generic;
using Codeguru_ICommandProblem.Models;

namespace Codeguru_ICommandProblem.ViewModels
{
    internal class ListaKategorii
    {
        public static IEnumerable<Kategoria> NowaLista()
        {
            for (var i = 0; i < 100; i++)
                yield return new Kategoria {Nazwa = String.Format("Nazwa {0}", i)};
        }
    }
}