#### Binary Search Tree
##### In computer science, a binary search tree (BST), also called an ordered or sorted binary tree, is a rooted binary tree data structure with the key of each internal node being greater than all the keys in the respective node's left subtree and less than the ones in its right subtree. 
##### The time complexity of operations on the binary search tree is linear with respect to the height of the tree.


```mermaid 
graph TB;

1((1))
2((2))
3((3))
4((4))

1-->2
2-->3
3-->4

```
```mermaid 
graph TB;

1((1))
3((3))
4((4))
6((6))
7((7))
8((8))
10((10))
13((13))
14((14))

8-->3
8-->10
3-->1
3-->6
10-->14
6-->4
6-->7
14-->13

```
