namespace XNAnimationSample
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main(string[] args)
        {
            using (AnimationSample game = new AnimationSample())
            {
                game.Run();
            }
        }
    }
}