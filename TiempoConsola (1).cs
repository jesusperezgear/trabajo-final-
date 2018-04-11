using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTiempo
{
    class Program
    {
        static void Main(string[] args)
        {

            int s, dd, mm, aa;
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Imprimir en numeros la fecha ingresada de acuerdo a la sgt tabla para dias y meses\n");
            Console.WriteLine("Dias de la semana\n");
            Console.WriteLine("1 = Lunes"); Console.WriteLine("2 = Martes"); Console.WriteLine("3 = Miercoles");
            Console.WriteLine("4 = Jueves"); Console.WriteLine("5 = Viernes"); Console.WriteLine("6 = Sabado");
            Console.WriteLine("7 = Domingo");

            Console.WriteLine("\nMeses del año\n");
            Console.WriteLine("1 = Enero"); Console.WriteLine("2 = Febrero"); Console.WriteLine("3 = Marzo");
            Console.WriteLine("4 = Abril"); Console.WriteLine("5 = Mayo"); Console.WriteLine("6 = Junio");
            Console.WriteLine("7 = Julio"); Console.WriteLine("8 = Agosto"); Console.WriteLine("9 = Septiembre");
            Console.WriteLine("10 = Octubre"); Console.WriteLine("11 = Noviembre"); Console.WriteLine("12 = Diciembre");
            Console.WriteLine("\n********************************************************************************");

            Console.WriteLine("\nIngrese la fecha que desea en el orden S/DD/MM/AA\n");
           
            Console.WriteLine("Ingrese el dia de la semana:\n");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el dia del mes(DD) de 1 al 31, Recuerde que febrero tiene 28 dias:\n");
            dd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el mes en numeros:\n");
            mm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el año desde 1900 hasta 2020\n");
            aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n********************************************************************************");

           
                switch (s)
                {

                    case 1:
                        Console.WriteLine("\nLunes");
                        break;

                    case 2:
                        Console.WriteLine("\nMartes");
                        break;
                    case 3:
                        Console.WriteLine("\nMiercoles");
                        break;
                    case 4:
                        Console.WriteLine("\nJueves");
                        break;

                    case 5:
                        Console.WriteLine("\nViernes");
                        break;
                    case 6:
                        Console.WriteLine("\nSabado");
                        break;
                    case 7:
                        Console.WriteLine("\nDomingo");
                        break;
                }

            

            switch(dd){
            
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.WriteLine("OCHO");
                    break;
                case 9:
                    Console.WriteLine("NUEVE");
                    break;
                case 10:
                    Console.WriteLine("DIEZ");
                    break;
                case 11:
                    Console.WriteLine("ONCE");
                    break;
                case 12:
                    Console.WriteLine("DOCE");
                    break;
                case 13:
                    Console.WriteLine("TRECE");
                    break;
                case 14:
                    Console.WriteLine("CATORCE");
                    break;
                case 15:
                    Console.WriteLine("QUINCE");
                    break;
                case 16:
                    Console.WriteLine("DIECISEIS");
                    break;
                case 17:
                    Console.WriteLine("DIECICIETE");
                    break;
                case 18:
                    Console.WriteLine("DIECIOCHO");
                    break;
                case 19:
                    Console.WriteLine("DIECINUEVE");
                    break;
                case 20:
                    Console.WriteLine("VEINTE");
                    break;
                case 21:
                    Console.WriteLine("VEINTI UNO");
                    break;
                case 22:
                    Console.WriteLine("VEINTI DOS");
                    break;
                case 23:
                    Console.WriteLine("VEINTI TRES");
                    break;
                case 24:
                    Console.WriteLine("VEINTI CUATRO");
                    break;
                case 25:
                    Console.WriteLine("VEINTI CINCO");
                    break;
                case 26:
                    Console.WriteLine("VEINTI SEIS");
                    break;
                case 27:
                    Console.WriteLine("VEINTI SIETE");
                    break;
                case 28:
                    Console.WriteLine("VEINTI OCHO");
                    break;
                case 29:
                    Console.WriteLine("VEINTI NUEVE");
                    break;
                case 30:
                    Console.WriteLine("TREINTA");
                    break;
                case 31:
                    Console.WriteLine("TREINTA Y UNO");
                    break;

                    }
                
            switch(mm){
            
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    if (dd <= 28)
                    { Console.WriteLine("Febrero"); }

                    else { Console.WriteLine("Este mes tiene 28 dias ingrese otra vez la fecha"); }

                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;}
            
            switch(aa){
            
                case 1990:
                    Console.WriteLine("Noventa");
                    break;

                case 1991:
                    Console.WriteLine("Noventa y uno");
                    break;
                case 1992:
                    Console.WriteLine("Noventa y dos");
                    break;
                case 1993:
                    Console.WriteLine("Noventa y tres");
                    break;
                case 1994:
                    Console.WriteLine("Noventa y cuatro");
                    break;
                case 1995:
                    Console.WriteLine("Noventa y cinco");
                    break;
                case 1996:
                    Console.WriteLine("Noventa y seis");
                    break;
                case 1997:
                    Console.WriteLine("Noventa y siete");
                    break;
                case 1998:
                    Console.WriteLine("Noventa y ocho");
                    break;
                case 1999:
                    Console.WriteLine("Noventa y nueve");
                    break;
                case 2000:
                    Console.WriteLine("Cero-Cero");
                    break;
                case 2001:
                    Console.WriteLine("Cero-Uno");
                    break;
                case 2002:
                    Console.WriteLine("Cero-Dos");
                    break;
                case 2003:
                    Console.WriteLine("Cero-Tres");
                    break;
                case 2004:
                    Console.WriteLine("Cero-Cuatro");
                    break;
                case 2005:
                    Console.WriteLine("Cero-Cinco");
                    break;
                case 2006:
                    Console.WriteLine("Cero-Seis");
                    break;
                case 2007:
                    Console.WriteLine("Cero-Siete");
                    break;
                case 2008:
                    Console.WriteLine("Cero-Ocho");
                    break;
                case 2009:
                    Console.WriteLine("Cero-Nueve");
                    break;
                case 2010:
                    Console.WriteLine("Diez");
                    break;
                case 2011:
                    Console.WriteLine("Once");
                    break;
                case 2012:
                    Console.WriteLine("Doce");
                    break;
                case 2013:
                    Console.WriteLine("Trece");
                    break;
                case 2014:
                    Console.WriteLine("Catorce");
                    break;
                case 2015:
                    Console.WriteLine("Quince");
                    break;
                case 2016:
                    Console.WriteLine("Dieciseis");
                    break;
                case 2017:
                    Console.WriteLine("Diecisiete");
                    break;
                case 2018:
                    Console.WriteLine("Dieciocho");
                    break;
                case 2019:
                    Console.WriteLine("Diecinueve");
                    break;
                case 2020:
                    Console.WriteLine("Veinte");
                    break;
                    
            
            }
            
            
            Console.ReadKey();
            
            
            
            
            
            }

            
            
            
         







            
        }
        }
    
