
using Search;

void main()
{
    Node nodeA = new Node("A");
    Node nodeB = new Node("B");
    Node nodeC = new Node("C");
    Node nodeD = new Node("D");
    Node nodeE = new Node("E");
    Node nodeF = new Node("F");
    Node nodeG = new Node("G");

    nodeA.setNeighbor(new List<Node> { nodeB, nodeC});
    nodeB.setNeighbor(new List<Node> { nodeA, nodeD, nodeE });
    nodeC.setNeighbor(new List<Node> { nodeA, nodeF, nodeG });
    nodeD.setNeighbor(new List<Node> { nodeB});
    nodeE.setNeighbor(new List<Node> { nodeB});
    nodeF.setNeighbor(new List<Node> { nodeC});
    nodeG.setNeighbor(new List<Node> { nodeC});


    DepthFirstSearch depthFirstSearch = new DepthFirstSearch(nodeA);

    BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch(nodeA);

    System.Console.WriteLine("Depth first search: ");
    depthFirstSearch.search();

    System.Console.WriteLine();
    
    System.Console.WriteLine("Breadth first search: ");
    breadthFirstSearch.search();

    System.Console.WriteLine();


    BinarySearch binarySearch = new BinarySearch(new int[] { 12, 10, 9, 5, 6, 2, 1 });

    int index = binarySearch.binarySearch(12);

    if (index > -1)
    {
        System.Console.WriteLine($"The item that you find is at index {index}");
    }
    else
    {
        System.Console.WriteLine("Not found.");
    }

}

main();