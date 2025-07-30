using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//base() richiama la superclasse. usato in  un costruttore di una classe derivata per chiamare il costruttore della classe base.
//base. accedere a un metodo o un attributo della classe base
namespace Quadrilateri
{
    internal class Rettangolo:Quadrilatero
    {
        public Rettangolo(double Base, double Altezza):base(Base,Altezza,Base,Altezza) { }  //chiocciola perche e una keyword, oppure _base @base

        //metodi
        public double Area() => base.lato1 * base.lato2;

        public double Diagonale() => Math.Sqrt(Math.Pow(lato1,2)+Math.Pow(lato2,2));

        public override string ToString() => $"{{base: {lato1}" +
            $", altezza: {lato2}" +
            $", perimetro: {Perimetro()}" +
            $", area: {Area()}" +
            $", diagonale: {Diagonale()}}}";
       
    }
}
