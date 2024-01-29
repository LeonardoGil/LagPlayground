namespace LagPlaygroundForms.Basketball
{
    public class PhysicalObjectControl : UserControl
    {
        protected const int Gravity = 10;

        protected double Weight { get; set; }

        protected double AccelerationX { get; set; }
     
        protected double AccelerationY { get; set; }

        protected double SpeedX { get; set; }

        protected double SpeedY { get; set; }

        protected DirectionEnum Direction { get; set; }

        protected double StrenghtX { get => Weight * AccelerationX; }

        protected double StrenghtY { get => Weight * AccelerationY; }
    }

    public enum DirectionEnum
    {
        North, 
        South,
        East,
        West,

        NorthEast,
        NorthWest,

        SouthEast,
        SouthWest
    }
}
