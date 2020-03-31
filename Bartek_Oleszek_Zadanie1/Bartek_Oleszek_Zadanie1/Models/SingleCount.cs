using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartek_Oleszek_Zadanie1.Models
{
    enum AreaType
    {
        Rectangle,
        Trapezoid
    }

    class SingleCount
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public int n { get; set; }
        public AreaType areaType { get; set; }
        public double area { get; set; }
        public double calculationNumber { get; set; }
        public int lowestN { get; set; }
        public double minSquareError { get; set; }

        public SingleCount() { }
        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, double calcNumber)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.n = n;
            this.areaType = areaType;
            this.area = area;
            this.calculationNumber = calcNumber;
        }
        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, double calcNumber, int lowestN)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.n = n;
            this.areaType = areaType;
            this.area = area;
            this.calculationNumber = calcNumber;
            this.lowestN = lowestN;
        }
    }

    class Global
    {
        public List<SingleCount> ListOfSingleCount { get; set; }

        public Global() { }
        public Global(List<SingleCount> list)
        {
            this.ListOfSingleCount = list;
        }
    }
}
