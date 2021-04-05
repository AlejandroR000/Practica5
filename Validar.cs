using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Validar
{
    public bool validacion(string ingresado, string pin)
    {
        if (ingresado == pin)
            return true;
        else
        return false;
    }

}  


