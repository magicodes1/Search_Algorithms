namespace Search
{
    public class BreadthFirstSearch
    {
        private Node startNode = null!;

        public BreadthFirstSearch(Node startNode)
        {
            this.startNode = startNode;
        }


        public void search(){
            Queue<Node> nodeQueue = new Queue<Node>();
            HashSet<Node> seen = new HashSet<Node>();

            nodeQueue.Enqueue(startNode);

            
            while (nodeQueue.Count > 0)
            {
                 Node node = nodeQueue.Dequeue();

                 if(!seen.Contains(node)){
                     seen.Add(node);
                     System.Console.Write($"{node.getName()} \t");
                 }

                 foreach (var item in node.getNeighbors())
                 {
                     if(!seen.Contains(item)){
                         nodeQueue.Enqueue(item);
                     }
                 }
            }
        }
    }
}