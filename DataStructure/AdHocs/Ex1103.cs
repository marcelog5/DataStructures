namespace DataStructure.Ad_Hocs
{
    public static class Ex1103
    {
        public static void Execute()
        {
            TimeDifference(21, 33, 21, 10);
        }

        private static int TimeDifference(int i, int j, int k, int l)
        {
            var hourDif = 0;
            var minuteDif = 0;

            if (k < i)
            {
                hourDif = 23 - i + k;
            }
            else
            {
                hourDif = k - i;
            }

            if (l < j)
            {
                minuteDif = 60 - j + l;
            }
            else
            {
                minuteDif = l - j;
            }

            return (hourDif * 60) + minuteDif;
        }

    }
}
