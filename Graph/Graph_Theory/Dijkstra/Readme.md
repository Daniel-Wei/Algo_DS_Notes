### Dijkstra Algorithm
- For **Weighted** Graphs **without negative** weights
- Time Complexity: O(Num_Of_Edges * Priority_Queue_Decrease_Key) + O(Number_Of_Vertices * Priority_Queue_Extract_Min)

- For solving the single source, all targets shortest path problem on grpahs without non-negaive weights
- Closely related to BFS
- It keeps track of a set of S nodes whose distance to the source has already been determined.
- Initially, S only contains the source node, and it grows by one element at a time until containing all nodes that are reachable from the source node
- At each iteration, from all nodes that are one edge away from S, add to S the node u that has the smallest distance to the source.
- By doing so, the overall effect is that the nodes will be added to S in increasing oder of distance to the source.
