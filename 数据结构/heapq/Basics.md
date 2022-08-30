### Priority Queue
  - Queue + Priority
  - Push：插入
  - Pop：弹出优先级最高
  - Peek：查看优先级最高
  - 按照priority的顺序，linked list，FIFO

### Heap
  - Insert
    - 第一步和Binary tree类似，但是不需要比较数值
    - 重复比较新插入节点与最近根节点的数值
    - swap if necessary, until max/min heap
 
  - Poll
    - 删除根节点
    - 新的root: last leaf
    - 比较替换新的left tree的根节点子节点
