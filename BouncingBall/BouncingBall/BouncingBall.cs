namespace BallBounce
{
    class BouncingBall
    {
        public static int BallBounces(double height, double bounceRate, double windowHeight)
        {
            // Everytime the ball bounces, it will pass the 
            // window twice, EXCEPT for the initial drop
            // to offset this --> -1 + 2(increment value below) = 1
            int windowPass = -1;

            if (IsInvalidExp(height, windowHeight, bounceRate))
                return windowPass;
            do
            {
                height *= bounceRate;
                windowPass += 2;

            } while (height > windowHeight);

            return windowPass;      
        }

        private static bool IsInvalidExp(double h, double wh, double br)
        {
            return (h < 0 || h < wh || h == wh || br <= 0 || br >= 1);
        }
    }
}
