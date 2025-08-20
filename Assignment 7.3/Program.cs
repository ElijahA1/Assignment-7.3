namespace Assignment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST bst = new();
            bst.InsertNewNode(bst.root, 11);
            bst.InsertNewNode(bst.root, 14);
            bst.InsertNewNode(bst.root, 7);
            bst.InsertNewNode(bst.root, 9);
            bst.InsertNewNode(bst.root, 5);
            bst.InsertNewNode(bst.root, 16);
            bst.InsertNewNode(bst.root, 12);
            Node realNode = new Node(7);
            Node fakeNode = new Node(13);

            if (bst.TrySearch(realNode.value, out Node temp)) // true
                bst.InOrderTraversal(temp);

            if (bst.TrySearch(fakeNode.value, out Node nullTemp)) // false
                bst.InOrderTraversal(nullTemp); // Value Does Not exist in current context

            Console.ReadKey();
        }
    }

    /*   Tree for Reference
     *          11(root)
     *         /  \
     *        7    14
     *       /\    /\
     *      5  9  12 16
     */
}
