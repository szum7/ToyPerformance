namespace BenchmarkApp
{
    public class ExampleSolution
    {
        public int BogusAddition(int param1, int param2)
        {
            switch (param1)
            {
                case 0: Thread.Sleep(10); break;
                case 1: Thread.Sleep(20); break;
                default: break;
            }
            return param1 + param2;
        }
    }
}
