using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_EntitiesSolarz;
using DI_LayoutSolarizr_JuanJosé_MuñozArenas;

namespace DI_DALSolarizr
{
    public class DALAppoiment
    {

        /// <summary>
        /// Method that simulate a connection to a database, returning a list of appoiments (that should be in the database)
        /// </summary>
        /// <returns> List<Appoiment> getListOfAppoiments() </returns>
        public static List<Appoiment> getListOfAppoiments()
        {
            List<Appoiment> appoiments = new List<Appoiment>();
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 3, 9, 30, 00), "Avería", new Costumer("SDK17", "C/Java lang Autoclosable Nº8 ", "74584538")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 13, 9, 30, 00), "Incidencia", new Costumer("Microsoft", "C/Windows Forms Nº2 ", "45471552")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 6, 9, 30, 00), "Avería", new Costumer("TextBox", "C/.setText Nº27", "54784553")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 3, 9, 30, 00), "Avería", new Costumer("SDK17", "C/Java lang Autoclosable Nº8 ", "74584538")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 13, 9, 30, 00), "Incidencia", new Costumer("Microsoft", "C/Windows Forms Nº2 ", "45471552")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 6, 9, 30, 00), "Avería", new Costumer("TextBox", "C/.setText Nº27", "54784553")));
            return appoiments;
        }

    }
}
