### Priority Queue
  - Queue + Priority
  - Insert：插入
  - 默认为最小优先
  - Poll：弹出优先级最高
  - Peek：查看优先级最高
  - 按照priority的顺序，linked list，FIFO
  - PriorityQueue<CustomClass> 中的 Custom Class需要implements Comparable<CustomClass> 以及 override compareTo
    ```java
    private class Cell implements Comparable<Cell>{
        int val;
        int row;
        int col;

        public Cell(int val, int row, int col){
            this.val = val;
            this.row = row;
            this.col = col;
        }

        @Override
        public int compareTo(Cell other) {
            // Min-heap comparison
            return Integer.compare(this.val, other.val);
        }
    }
    ```

- compareTo
  ```java
  @Override
  public int compareTo(Cell other) {
      // Min-heap comparison: as if this.val < other.val, res = this.val - other val < 0, no position swapping, 'this' is before 'other'
      return Integer.compare(this.val, other.val);
  }

  @Override
  public int compareTo(Cell other) {
      // Man-heap comparison: as if this.val > other.val, res = other.val - this.val < 0, swap positions, 'this' is before 'other'
      return Integer.compare(other.val, this.val);
  }
  ```

### Heap
  - Insert
    - 第一步和Binary tree类似，但是不需要比较数值
    - 重复比较新插入节点与最近根节点的数值
    - swap if necessary, until max/min heap
 
  - Poll
    - 删除根节点
    - 新的root: last leaf
    - 比较替换新的left tree的根节点子节点
