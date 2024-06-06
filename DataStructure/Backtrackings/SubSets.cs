namespace DataStructure.Backtrackings
{
    public class SubSets
    {
        public List<List<int>> GetSubSets(int[] set)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> subSet = new List<int>();

            Dfs(0, subSet, res, set);
            return res;
        }

        private void Dfs(int i, List<int> subSet, List<List<int>> res, int[] set)
        {
            if (i >= set.Length)
            {
                res.Add(subSet.ToList());
                return;
            }

            // decision to include nums[i]
            subSet.Add(set[i]);
            Dfs(i + 1, subSet, res, set);

            // decision to exclude nums[i]
            subSet.RemoveAt(subSet.Count - 1);
            Dfs(i + 1, subSet, res, set);
        }
    }
}
