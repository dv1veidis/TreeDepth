
class TreeDepth
{
    class Count
    {
        public
        int Value { get; set; } = 0;
    }
    class Branch
    {
        public
        List<Branch> branches
            { get; set; } = new();
    }

    private static void Depth(Branch mainBranch, Count Count, int count)
    {
        if (mainBranch.branches.Count == 0)
        {
            if (Count.Value < count) Count.Value = count;
        }
        else if (mainBranch.branches.Count == 1)
        {
            count++;
            Depth(mainBranch.branches[0], Count, count);
        }
        else
        {
            count++;
            foreach(Branch branch in mainBranch.branches)
            {
                Depth(branch, Count, count);
            }
        }
    }

    public static void Main()
    {
        Branch mainBranch= new();
        Count Count = new();
        mainBranch.branches.Add(new Branch());
        mainBranch.branches.Add(new Branch());
        mainBranch.branches[0].branches.Add(new Branch());
        mainBranch.branches[1].branches.Add(new Branch());
        mainBranch.branches[1].branches.Add(new Branch());
        mainBranch.branches[1].branches.Add(new Branch());
        mainBranch.branches[1].branches[0].branches.Add(new Branch());
        mainBranch.branches[1].branches[1].branches.Add(new Branch());
        mainBranch.branches[1].branches[1].branches.Add(new Branch());
        mainBranch.branches[1].branches[1].branches[0].branches.Add(new Branch());
        Depth(mainBranch, Count, 1);
        Console.WriteLine(Count.Value);

    }
}