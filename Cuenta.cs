using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cuenta
{

    private string nombreTitular;
    private double saldo;
    private string nip;


    public Cuenta(string nombreTitular, double saldo, string nip)
    {
        this.nombreTitular = nombreTitular;
        this.saldo = saldo;
        this.nip = nip;
    }

    public Cuenta()
    {
        this.nombreTitular = "";
        this.saldo = 0;
        this.nip = "";
    }
    



    public void ingresar(double importe)
    {
        if (importe > 0)
            this.saldo += importe;

    }

    public void retirar(double importe)
    {
        if (importe > 0)
            this.saldo -= importe;

    }



    public string NombreTitular { get => nombreTitular; set => nombreTitular = value; }


    public double Saldo
    {
        get => saldo;

        set
        {
            if (saldo >= 0)
                saldo = value;
            // valida que el valor sea mayor o igual a 0
            // si no lo es, el saldo permanece sin cambios
        }

    }

    public string Nip { get => nip; set => nip = value; }

}

