using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_15_Transitions.Model
{
    public class ViewModel:clsVMBase
    {

        public ObservableCollection<Persona> Listado { get; set; }

        public ViewModel()
        {
            Listado = new ObservableCollection<Persona>();
            Persona persona1 = new Persona();
            persona1.Nombre = "Javi";
            Listado.Add(persona1);
            Listado.Add(persona1);
            Listado.Add(persona1);
        }
    }
}
