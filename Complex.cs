using System;

namespace ComplexNumbers
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        public static Complex operator +(Complex l, Complex r)
        {
            return new Complex(){Real =  l.Real + r.Real, Imaginary = l.Imaginary + r.Imaginary};
        }

        public static Complex operator -(Complex l, Complex r)
        {
            return new Complex() {Real = l.Real - r.Real, Imaginary = l.Imaginary - r.Imaginary};
        }

        public static Complex operator *(Complex l, Complex r)
        {
            return new Complex()
            {
                Real = l.Real * r.Real - l.Imaginary * r.Imaginary,
                Imaginary = l.Imaginary * r.Real + l.Real * r.Imaginary
            };
        }

        public static Complex operator /(Complex u, Complex d)
        {
            return new Complex()
            {
                Real = (u.Real * d.Real + u.Imaginary * d.Imaginary) / (Math.Pow(d.Real, 2) + Math.Pow(d.Imaginary, 2)),
                Imaginary = (u.Imaginary * d.Real - u.Real * d.Imaginary) /
                            (Math.Pow(d.Real, 2) + Math.Pow(d.Imaginary, 2))
            };
        }

        public static Complex operator -(Complex l, int r)
        {
            return new Complex() {Real = l.Real - r, Imaginary = l.Imaginary - 0};
        }
        
        public static Complex operator -(int l, Complex r)
        {
            return new Complex() {Real = r.Real - l, Imaginary = r.Imaginary - 0};
        }
        
        public static Complex operator +(Complex l, int r)
        {
            return new Complex() {Real = l.Real + r, Imaginary = l.Imaginary + 0};
        }
        
        public static Complex operator +(int l, Complex r)
        {
            return new Complex() {Real = r.Real + l, Imaginary = r.Imaginary + 0};
        }

        public static Complex operator *(int l, Complex r)
        {
            return new Complex() {Real = r.Real * l - r.Imaginary * 0, Imaginary = r.Imaginary * l + r.Real * 0};
        }
        
        public static Complex operator *(Complex l, int r)
        {
            return new Complex() {Real = l.Real * r - l.Imaginary * 0, Imaginary = l.Imaginary * r + l.Real * 0};
        }

        public static bool operator ==(Complex l, Complex r)
        {
            return l.Real == r.Real && l.Imaginary == r.Imaginary;
        }
        
        public static bool operator !=(Complex l, Complex r)
        {
            return !(l == r);
        }
        
    }
}