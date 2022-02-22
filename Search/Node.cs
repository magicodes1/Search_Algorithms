using System.Collections;

namespace Search
{
    public class Node
    {
        string name="";
        List<Node> neighbors = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public string getName(){
            return this.name;
        }

        public void setNeighbor(List<Node> neighbors){
            this.neighbors = neighbors;
        }


        public List<Node> getNeighbors(){
            return this.neighbors;
        }


    }
}