using System;

namespace lab_atdd_corebdd.domain
{
    public class Calculadora
    {
        public string Ecuacion { get; set; }
        public int Total   { get; set; }
        public int Sumar(int x, int y) => x + y;
        public int Restar(int x, int y) => x - y;
        public Calculadora Factor(int value)      { Total = value;  Ecuacion = value.ToString(); return this; }
        public Calculadora Suma(int value)      { Total += value; Ecuacion += " + " + value;   return this; }
        public Calculadora Resta(int value) { Total -= value; Ecuacion += " - " + value;   return this; }
        public Calculadora Multiplica(int value) { Total *= value; Ecuacion += " x " + value;   return this; }
        public Calculadora Divide(int value)   { Total /= value; Ecuacion += " / " + value;   return this; }
        public Calculadora Limpiar()                 { Total = 0;      Ecuacion = "";               return this; }
    }
}
