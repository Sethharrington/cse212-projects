public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var listMerged = new int[select.Length];
        int list1Count = 0;
        int list2Count = 0;
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                listMerged[i] = list1[list1Count];
                list1Count++;
            }
            else if (select[i] == 2)
            {
                listMerged[i] = list2[list2Count];
                list2Count++;
            }
            else
            {
                Console.WriteLine("Incorrect array selected");
            }
        }
        return listMerged;
    }
}