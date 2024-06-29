### Directed Acyclic Graph
#### A Directed Acyclic Graph (DAG) is a graph where each edge has a defined direction from one vertex to another and following these edges will never create a closed loop.

```mermaid 
graph TB;

1((1))
2((2))
3((3))
4((4))
5((5))

1-->2
1-->3
1-->4
2-->3
4-->3
3-->5
4-->5
1-->5
