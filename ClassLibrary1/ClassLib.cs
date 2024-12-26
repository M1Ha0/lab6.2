namespace ClassLab6_2
{
    public class ClassLib
    {
        public static int[] Sum(int[,] mas)
        {
            int[] sumColum = new int[mas.GetLength(1)];
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                int s = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    s += mas[i, j];
                }
                sumColum[j] = s;
            }
            return sumColum;
        }
     }
}
