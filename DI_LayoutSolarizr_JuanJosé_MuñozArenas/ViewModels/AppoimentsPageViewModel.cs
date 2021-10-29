using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas.ViewModels
{
    public class AppoimentsPageViewModel
    {
        private List<Appoiment> appoiments = new List<Appoiment>();

        public AppoimentsPageViewModel(){
            appoiments = new List<Appoiment>();
            this.fillListAppoiments();
        }

        public List<Appoiment> Appoiments
        {
            get { return appoiments; }
        }

        public void fillListAppoiments(){
            appoiments.Add(new Appoiment("Instalación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Incidencia con equipo, posiblemenete necesite reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Instalación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Incidencia con equipo, posiblemenete necesite reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Instalación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Incidencia con equipo, posiblemenete necesite reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Instalación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
            appoiments.Add(new Appoiment("Incidencia con equipo, posiblemenete necesite reparación", "C/Alvar Nuñez Cabeza de Vaca Nº11", "ERER"));
        }
    }
}
