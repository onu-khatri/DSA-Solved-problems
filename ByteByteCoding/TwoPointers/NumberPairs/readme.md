## Pair Sum - Sorted

**Difficulty**: Easy

### Problem Description:
Given an array of integers sorted in ascending order and a target value, return the indexes of any pair of numbers in the array that sum to the target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.

### Example 1:
**Input**:  
`nums = [-5, -2, 3, 4, 6]`, `target = 7`  

**Output**:  
`[2, 3]`  

**Explanation**:  
`nums[2] + nums[3] = 3 + 4 = 7`.

---

### Example 2:
**Input**:  
`nums = [1, 1, 1]`, `target = 2`  

**Output**:  
`[0, 1]`  

**Explanation**:  
Other valid outputs could be:  
`[1, 0]`, `[0, 2]`, `[2, 0]`, `[1, 2]`, or `[2, 1]`.

----------

## Triplet Sum

**Difficulty**: Medium

### Problem Description:
Given an array of integers, return all triplets `[a, b, c]` such that `a + b + c = 0`. The solution must not contain duplicate triplets (e.g., `[1, 2, 3]` and `[2, 3, 1]` are considered duplicates). If no such triplets are found, return an empty array.

Each triplet can be arranged in any order, and the output can be returned in any order.

### Example:
**Input**:  
`nums = [0, -1, 2, -3, 1]`  

**Output**:  
`[[-3, 1, 2], [-1, 0, 1]]`

---

