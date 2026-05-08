//using System;
//using System.Collections.Generic;
//using System.Text;

//using System;

//namespace ColorSpace
//{
//    public enum Channel
//    {
//        Red,
//        Green,
//        Blue
//    }

//    public struct RGBColor
//    {
//        public int R { get; }
//        public int G { get; }
//        public int B { get; }

//        public RGBColor(int r, int g, int b)
//        {
//            R = Math.Clamp(r, 0, 255);
//            G = Math.Clamp(g, 0, 255);
//            B = Math.Clamp(b, 0, 255);
//        }

//        //HEX
//        public string ToHex()
//        {
//            return $"#{R:X2}{G:X2}{B:X2}";
//        }

//        //HSL(вперше чую за цей формат, чесно кажучи))
//        public (double H, double S, double L) ToHSL()
//        {
//            double r = R / 255.0;
//            double g = G / 255.0;
//            double b = B / 255.0;

//            double max = Math.Max(r, Math.Max(g, b));
//            double min = Math.Min(r, Math.Min(g, b));
//            double l = (max + min) / 2.0;
//            double h, s;

//            if (Math.Abs(max - min) < 0.0001)
//            {
//                h = s = 0; // ахроматичний
//            }
//            else
//            {
//                double d = max - min;
//                s = l > 0.5 ? d / (2.0 - max - min) : d / (max + min);

//                if (max == r)
//                    h = (g - b) / d + (g < b ? 6 : 0);
//                else if (max == g)
//                    h = (b - r) / d + 2;
//                else
//                    h = (r - g) / d + 4;

//                h *= 60.0;
//            }

//            return (h, s, l);
//        }

//        //CMYK(аналогічно)
//        public (double C, double M, double Y, double K) ToCMYK()
//        {
//            double r = R / 255.0;
//            double g = G / 255.0;
//            double b = B / 255.0;

//            double k = 1.0 - Math.Max(r, Math.Max(g, b));
//            double c, m, y;

//            if (Math.Abs(k - 1.0) < 0.0001)
//            {
//                c = m = y = 0.0;
//            }
//            else
//            {
//                c = (1.0 - r - k) / (1.0 - k);
//                m = (1.0 - g - k) / (1.0 - k);
//                y = (1.0 - b - k) / (1.0 - k);
//            }

//            return (c, m, y, k);
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            RGBColor color = new RGBColor(120, 200, 150);

//            Console.WriteLine($"HEX: {color.ToHex()}");

//            var (h, s, l) = color.ToHSL();
//            Console.WriteLine($"HSL: H={h:F2} S={s:F2} L={l:F2}");

//            var (c, m, y, k) = color.ToCMYK();
//            Console.WriteLine($"CMYK: C={c:F2} M={m:F2} Y={y:F2} K={k:F2}");
//        }
//    }
//}

