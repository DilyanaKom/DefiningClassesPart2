namespace DefinigClassesPartTwo
{

    //Problem 1. Structure
    public struct Point3D
    {
        //Problem 2. Static read-only field
        private static readonly Point3D startOfEuclideanSpace=new Point3D() { PointX = 0, PointY = 0, PointZ = 0 };

        //Problem 1. Structure - Properties
        public double PointX{ get; set; }

        public double PointY { get; set; }

        public double PointZ { get; set; }

        //Problem 2. Static read-only field - Property
        public static Point3D StartOfEuclideanSpace
        {
            get
            {
                return startOfEuclideanSpace;
            }
        }


        //Problem 1. Structure - Implement ToString() to enable printing a 3D point
        public override string ToString()
        {
            return string.Format("X:{0}, Y:{1}, Z:{2}",PointX,PointY,PointZ);
        }

    }
}
