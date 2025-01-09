### Java中String相关的注意事项

1. 获取char：charAt，不可以直接indexing []

2. 长度：length()

3. 比较：使用.equals()，而不是==。因为==会比较val和内存地址。

4. 重复单一字符构建String："x".repeat(nTimes)

5. split("delimiter")
     - 注意delimiter是String不是char
     - 注意可能会split出来empty String

6. StringBuilder()
     - 长度：length()
     - 直接使用int构建String：StringBuilder().append()
     - 获取string：StringBuilder().toString()
     - 改变index上的char：StringBuilder().setChatAt(index, newChar)
     - 改变index上的substring：StringBuilder().insert(index, subString)
     - 直接获得substring：StringBuilder().substring(startIndex) (startIndex inclusive)

7. char array
     - 长度：length
     - char array构建String：char[].toString()
     - String构建char array：string.toCharArray

7. indexOf(str)
     - get first occurrence of str‘s start index or 0 for no occurrences
