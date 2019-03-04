namespace BallBounce
{
    class BouncingBall
    {
        public static int bouncingBall(double height, double bounceRate, double windowHeight)
        {
            // Originally, this was set to 1, but 
            // then my expected output was 2 over
            int windowPass = -1;

            if (height < 0 || height < windowHeight || bounceRate <= 0 || bounceRate >= 1)
                return windowPass;
            do
            {
                height = height * bounceRate;
                // windowPass needs to be incremented by 
                // 2 in order to account for the mom seeing the
                // ball pass by the window! 
                windowPass += 2;

            } while (height > windowHeight);

            return windowPass;
        }
    }
}

