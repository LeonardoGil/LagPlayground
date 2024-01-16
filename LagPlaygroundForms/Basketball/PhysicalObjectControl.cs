namespace LagPlaygroundForms.Basketball
{
    public class PhysicalObjectControl : UserControl
    {
        public const int Gravity = 10;

        public double Weight { get; set; }

        /// <summary>
        /// Velocidade m/s (metros por segundo)
        /// </summary>
        public int Acceleration { get; set; }

        /// <summary>
        /// Força em Newtow
        /// </summary>
        public int Strength { get; set; }

        public DirectionEnum Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gravity">m/s (Metros por segundo)</param>
        public void ActionOfGravity(int gravity)
        {
            var strenght = (int)(gravity * Weight);

            ApplyStrenght(DirectionEnum.South, strenght);
        }

        public void ApplyStrenght(DirectionEnum directionStrenght, int strenght)
        {
            switch (directionStrenght)
            {
                case DirectionEnum.North:




                    break;
                
                
                
                
                
                
                
                
                case DirectionEnum.South:
                    break;
                case DirectionEnum.East:
                    break;
                case DirectionEnum.West:
                    break;
                case DirectionEnum.NorthEast:
                    break;
                case DirectionEnum.NorthWest:
                    break;
                case DirectionEnum.SouthEast:
                    break;
                case DirectionEnum.SouthWest:
                    break;
                default:
                    break;
            }
        }

        #region Apply Strenght Direction
        private void ApplyStrenghtNorth(int strenght)
        {
            switch (Direction)
            {
                case DirectionEnum.North:
                    Strength += strenght;
                    break;

                case DirectionEnum.South:
                    Strength -= strenght;
                    break;

                case DirectionEnum.East:
                    Strength = CalculatePerpendicularForce(Strength, strenght);
                    break;

                case DirectionEnum.West:
                    break;

                case DirectionEnum.NorthEast:
                    break;
                case DirectionEnum.NorthWest:
                    break;
                case DirectionEnum.SouthEast:
                    break;
                case DirectionEnum.SouthWest:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Calculations

        private int CalculatePerpendicularForce(int strenghtX, int strenghtY)
        {
            return (int)Math.Sqrt((strenghtX * strenghtX) + (strenghtY * strenghtY));
        }

        #endregion

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
