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

        // Do not insert duplicates
        if (value == Data)
            return;

        // Determine direction (left or right)
        var nodeToInsert = value < Data ? Left : Right;
        
        // Insert in the corresponding address
        if (nodeToInsert == null)
        {
            // If the destination node is null, create a new node
            if (value < Data)
                Left = new Node(value);
            else
                Right = new Node(value);
        }
        else
        {
            // If not null, do recursive insertion
            nodeToInsert.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // Compare the value with the current node
        if (value == Data) 
        {
            return true;
        }

        // If the value is less, we search in the left subtree
        if (value < Data) 
        {
            return Left?.Contains(value) ?? false; 
        }

        // If the value is greater, we search in the right subtree
        return Right?.Contains(value) ?? false; 
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = Left != null ? Left.GetHeight() : 0;
        int rightHeight = Right != null ? Right.GetHeight() : 0;

        return 1 + (leftHeight > rightHeight ? leftHeight : rightHeight);
    }
}