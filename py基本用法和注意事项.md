### 基本用法 xxx
  - 直接获取arr的index以及elements：for i, ele in enumerate(arr)

  - Revserse 
    - String: s = s[::-1]
    - Array: arr = arr[::-1] or arr.revsers()

  - Sorted
    - 基本sorted arr = sorted(arr)
    - 根据每个ele的第n个val进行sort: arr = sorted(arr, key = lambda x: x[n])
    - arr = [[word, freq]], 要求结果先freq order从大到小再lexicographical order从小到大，实际上要反过来sorted
      - arr = sorted(arr, key = lambda x : x[0]) # 先lexicographical order从小到大
      - arr = sorted(arr, key = lambda x : x[1], reverse = True) #再freq order从大到小







### 注意事项
