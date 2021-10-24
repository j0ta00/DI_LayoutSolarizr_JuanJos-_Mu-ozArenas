using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas
{
    public class Appoiment
    {
        #region privates atributes
        private String name;
        private String address;
        private String details;
        #endregion

        #region constructors
        public Appoiment()
        {
            this.name = "default";
            this.address = "default address";
            this.details = "empty details";
        }
        public Appoiment(String name, String address, String details)
        {
            this.name = name;
            this.address = address;
            this.details = details;
        }
        #endregion

        #region getters & setters
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Details { get => details; set => details = value; }

        public override string ToString()
        {
            return $"{Name}\n{Address}";
        }
        #endregion
    }
    
}