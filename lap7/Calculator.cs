using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7
{
    internal class Calculator<T> where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {

        public Func<T, T, T> Addopration {  get; set; }
        public Func<T,T, T> Subtractopration{  get; set; }
        public Func<T, T, T>Multiplyopration { get; set; }
        public Func<T, T,T> Divideopration {  get; set; } 

       

        public T Add(T x ,T y)
        {
            return Addopration(x,y) ;
                
        }
        public T Subtract(T x, T y)
        {
            return Subtractopration(x,y);

        }
        public T Multiply(T x, T y)
        {
            return Multiplyopration(x,y);
        }
        public T Divide(T x, T y)
        {
            return Divideopration(x,y);
        }


       public Calculator()
        {
            Addopration = (x,y) => (dynamic)x +(dynamic) y ;
            Subtractopration = (x,y) =>(dynamic) x - (dynamic)y ;
            Multiplyopration = (x,y) =>(dynamic) x * (dynamic)y;
            Divideopration = (x,y) =>(dynamic) x / (dynamic)y;
        }
        
    }
}
