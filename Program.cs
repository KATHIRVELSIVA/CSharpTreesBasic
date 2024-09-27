//Tree Structure Implementation in C#
public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

//Binary Tree

public class BinaryTree
{
    public TreeNode Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }


    //Method for Inserting the value into the tree
    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private TreeNode InsertRec(TreeNode root, int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        if (value < root.Value)
        {
            root.Left = InsertRec(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = InsertRec(root.Right, value);
        }
        return root;
    }


    //Method for Printing the Tree InOrder Traversal
    public void InOrderTraversal()
    {
        InOrderRec(Root);
    }

    public void InOrderRec(TreeNode root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write($"{root.Value} ");
            InOrderRec(root.Right);
        }
    }


    //PreOrderTraversal
    public void PreOrderTraversal()
    {
        PreOrderRec(Root);
    }

    public void PreOrderRec(TreeNode root)
    {
        if (root != null)
        {
            Console.Write($"{root.Value} ");
            PreOrderRec(root.Left);
            PreOrderRec(root.Right);
        }
    }


    //PostOrderTraversal
    public void PostOrderTraversal()
    {
        PostOrderRec(Root);
    }

    public void PostOrderRec(TreeNode root)
    {
        if (root != null)
        {
            PostOrderRec(root.Left);
            PostOrderRec(root.Right);
            Console.Write($"{root.Value} ");
        }
    }

    //Search method in Tree
    public bool Search(int value)
    {
        return SearchRec(Root, value);
    }

    public bool SearchRec(TreeNode root, int value)
    {
        if (root == null)
        {
            return false;
        }
        if (root.Value == value)
        {
            return true;
        }
        return value < root.Value ? SearchRec(root.Left, value) : SearchRec(root.Right, value);
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        BinaryTree binaryTree = new();
        binaryTree.Insert(3);
        binaryTree.Insert(42);
        binaryTree.Insert(32);
        binaryTree.InOrderTraversal();
        binaryTree.PreOrderTraversal();
        binaryTree.PostOrderTraversal();
        Console.WriteLine();
        Console.WriteLine(binaryTree.Search(32));
        Console.WriteLine(binaryTree.Search(44));
    }
}