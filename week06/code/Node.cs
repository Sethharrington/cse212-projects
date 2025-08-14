public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value != Data)
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        if (value < Data)
            return (Left is null) ? false : Left.Contains(value);
        else if (value > Data)
            return (Right is null) ? false : Right.Contains(value);
        return value == Data;
    }

    public int GetHeight(int heightLeft = 1, int heightRight = 1, int max = 1)
    {

        heightLeft = (Left is null) ? max : Left.GetHeight(heightLeft + 1, heightRight, max);
        max = heightLeft > heightRight ? heightLeft : heightRight;

        heightRight = (Right is null) ? max : Right.GetHeight(heightLeft, heightRight + 1, max);
        max = heightLeft > heightRight ? heightLeft : heightRight;


        return max;
    }
}