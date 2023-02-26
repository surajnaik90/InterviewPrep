/*
Given an directed acyclic graph having A nodes. A matrix B of size M x 2 is given which represents the
M edges such that there is a edge directed from node B[i][0] to node B[i][1].

Topological sorting for Directed Acyclic Graph (DAG) is a linear ordering of vertices such that for every 
directed edge uv, vertex u comes before v in the ordering. Topological Sorting for a graph is not possible if the
graph is not a DAG.

Return the topological ordering of the graph and if it doesn't exist then return an empty array.

If there is a solution return the correct ordering. If there are multiple solutions print the lexographically smallest one.

Ordering (a, b, c) is said to be lexographically smaller than ordering (e, f, g) if a < e or if(a==e) then b < f and so on.

NOTE:

There are no self-loops in the graph.
There are no multiple edges between two nodes.
The graph may or may not be connected.
Nodes are numbered from 1 to A.
Your solution will run on multiple test cases. If you are using global variables make sure to clear them.


Problem Constraints
2 <= A <= 104

1 <= M <= min(100000,A*(A-1))

1 <= B[i][0], B[i][1] <= A

Input Format
The first argument given is an integer A representing the number of nodes in the graph.

The second argument given a matrix B of size M x 2 which represents the M edges such that there is a 
edge directed from node B[i][0] to node B[i][1].

Output Format
Return a one-dimensional array denoting the topological ordering of the graph and it it doesn't exist 
then return empty array.


Example Input
Input 1:

 A = 6
 B = [  [6, 3] 
        [6, 1] 
        [5, 1] 
        [5, 2] 
        [3, 4] 
        [4, 2] ]
Input 2:

 A = 3
 B = [  [1, 2]
        [2, 3] 
        [3, 1] ]


Example Output
Output 1:

 [5, 6, 1, 3, 4, 2]
Output 2:

 []


Example Explanation
Explanation 1:

 The given graph contain no cycle so topological ordering exists which is [5, 6, 1, 3, 4, 2]
Explanation 2:

 The given graph contain cycle so topological ordering not possible we will return empty array.
 */

public class TPSortItem : IComparable<TPSortItem>
{
    public int indegree;
    public int priority;
    public List<int> edges;
    public int node;
    public TPSortItem() {}
    public TPSortItem(int val, int priority)
    {
        this.indegree = val;
        this.priority = priority;
    }

    public int CompareTo(TPSortItem other)
    {
        if (this.priority < other.priority) return -1;
        else if (this.priority > other.priority) return 1;
        else if (this.priority == other.priority) {

            if (this.node < other.node) {
                return -1;
            }
            else if(this.node > other.node) {
                return 1;
            }
            else { 
                return 0; 
            }
        }
        else {
            return 0;
        }
    }
}

public static class TopologicalSort
{
    public static List<int> solve(int A, List<List<int>> B)
    {
        List<int> result = new List<int>();
        Dictionary<int, TPSortItem> map = new Dictionary<int, TPSortItem>();
        PriorityQueue<TPSortItem> queue = new PriorityQueue<TPSortItem>();
        int[] visited = new int[A + 1];

        //Initialize hash map
        for (int i = 1; i <= A; i++) {
            
            TPSortItem item = new TPSortItem();
            item.edges = new List<int>();
            item.indegree = 0;
            item.node = i;

            map.Add(i, item);
        }

        //Create a indegree for all the nodes in the graph
        for (int i = 0; i < B.Count; i++) {
            map[B[i][1]].indegree++;
            map[B[i][0]].edges.Add(B[i][1]);
        }

        //Create a priority queue for all the nodes. 
        //Priority would be indegree
        for (int i = 0; i < map.Count; i++) {

            TPSortItem item = new TPSortItem();

            item.priority = map.ElementAt(i).Value.indegree;
            item.edges = map.ElementAt(i).Value.edges;
            item.node = map.ElementAt(i).Key;
            item.indegree = map.ElementAt(i).Value.indegree;

            queue.Enqueue(item);
        }

        TPSortItem tpsortitem = queue.Peek();

        if(queue.Peek().indegree != 0) {
            return result;
        }

        //Generate the topological sort
        while(queue.Count() > 0) {

            TPSortItem item = queue.Dequeue();

            if (visited[item.node] == 1) {
                continue;
            }

            for (int i = 0; i < item.edges.Count; i++) {

                map[item.edges[i]].indegree--;

                TPSortItem tpItem = new TPSortItem();

                tpItem.priority = map[item.edges[i]].indegree;
                tpItem.edges = map[item.edges[i]].edges;
                tpItem.node = map[item.edges[i]].node;
                tpItem.indegree = map[item.edges[i]].indegree;

                queue.Enqueue(tpItem);

            }

            visited[item.node] = 1;
            result.Add(item.node);
        }

        return result;
    }
}