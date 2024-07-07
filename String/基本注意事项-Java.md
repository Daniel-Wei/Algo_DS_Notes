### Java中String相关的注意事项
1. 获取char：charAt，不可以直接indexing []
2. 长度：length()
3. 比较：使用.equals()，而不是==。因为==会比较val和内存地址。
4. StringBuilder()
     - 长度：length()
     - 直接使用int构建string：StringBuilder().append()
     - 获取string：StringBuilder().toString()
