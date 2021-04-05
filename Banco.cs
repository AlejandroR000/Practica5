using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Banco
{
    static void Main(string[] args)
    {

       Cuenta[] usuario = new Cuenta[100];
        Validar clave = new Validar();

        int i = 0;
        int opc;

        do
        {


            Console.Write("\n\t Selecciona una opcion" +
                "\n 1) Crear cuenta" +
                "\n 2) Acceder a mi cuenta" +
                "\n 3) Depositar" +
                "\n 4) Retirar" +
                "\n 0) Salir" +
                "\n >>> ");

                
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:

                    usuario[i] = new Cuenta();
                    Console.Write("\n Nombre: ");
                    usuario[i].NombreTitular = Convert.ToString(Console.ReadLine());

                    Console.Write("\n NIP: ");
                    usuario[i].Nip = Convert.ToString(Console.ReadLine());

                    Console.Write("\n Saldo a ingresar: ");
                    usuario[i].Saldo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine($"\n *** Titular: {usuario[i].NombreTitular}" +
                        $"\n *** NIP: {usuario[i].Nip}" +
                        $"\n *** Saldo: { usuario[i].Saldo}");
                    Console.WriteLine("\n-------------------------------------");

                    i++;

                    break;

                case 2:

                    Console.Write("\n NIP: ");
                    string pass = Convert.ToString(Console.ReadLine());
                    
                    

                    for(int j=0; j<usuario[j].Nip.Length; j++)
                    {
                        if(clave.validacion(pass,usuario[j].Nip))
                        {
                            Console.WriteLine("\n-------------------------------------");
                            Console.WriteLine($"\n >>>> Titular: {usuario[j].NombreTitular}" +
                              $"\n >>>> NIP: {usuario[j].Nip}" +
                               $"\n >>>> Saldo: { usuario[j].Saldo}");
                            Console.WriteLine("\n-------------------------------------");
                            break;
                        }

                    }

                    break;

                case 3:
                    Console.Write("\n NIP: ");
                    pass = Convert.ToString(Console.ReadLine());

                    for (int j = 0; j < usuario[j].Nip.Length; j++)
                    {
                        if (clave.validacion(pass, usuario[j].Nip))
                        {
                            Console.Write("\n Cuanto vas a ingresar: ");
                            int importe = Convert.ToInt32(Console.ReadLine());
                            usuario[j].ingresar(importe);

                            break;
                        }

                    }

                    break;

                case 4:

                    Console.Write("\n NIP: ");
                    pass = Convert.ToString(Console.ReadLine());

                    for (int j = 0; j < usuario[j].Nip.Length; j++)
                    {
                        if (clave.validacion(pass, usuario[j].Nip))
                        {
                            Console.Write("\n Cuanto vas a retirar: ");
                            int importe = Convert.ToInt32(Console.ReadLine());
                            usuario[j].retirar(importe);

                            break;
                        }

                    }

                    break;


                default: Console.WriteLine("\n Digito invalido"); break;

            }

        } while (opc != 0);



    }
}

