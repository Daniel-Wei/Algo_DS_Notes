### Array Deque

#### ArrayDeque主要是基于数组实现的Deque(Double Ended Queue)双端队列，即双端队列，它既可以当作栈使用，也可以当作队列使用。
- ArrayDeque是一个没有容量限制的双端队列，底层是基于数组实现，会自动扩容。
- ArrayDeque不是线程安全的。
- ArrayDeque不可以存取null元素。
- 当作为栈使用时，性能比Stack好；当作为队列使用时，性能比LinkedList好。
