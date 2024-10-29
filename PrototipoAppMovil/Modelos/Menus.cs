using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoAppMovil.Modelos
{
    public class Menus
    {
        [Key] public string idMenu { get; set; }
        public string descripcion { get; set; }
        public int valor {  get; set; }
        
    }
}
