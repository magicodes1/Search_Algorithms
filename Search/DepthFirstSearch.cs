namespace Search
{
    public class DepthFirstSearch {
        
        private Node startNode = null!;

        public DepthFirstSearch(Node node)
        {
            this.startNode = node;
        }

        public void search(){
            Stack<Node> nodeStack = new Stack<Node>();

            HashSet<Node> seen = new HashSet<Node>();

            nodeStack.Push(startNode);
            
            while (nodeStack.Count()>0)
            {
                 Node node = nodeStack.Pop();

                 if(!seen.Contains(node)){
                     seen.Add(node);
                     System.Console.Write($"{node.getName()} \t");
                 }

                 foreach (var item in node.getNeighbors())
                 {
                     if(!seen.Contains(item)){
                         nodeStack.Push(item);
                     }
                 }
            }
        }

    }
}