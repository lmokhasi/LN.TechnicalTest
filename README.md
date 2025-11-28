# DeepestPitQuestion
The deepest pit technical seed project

## Requirement

- Given an array of coordinates that plot pits and hills on a graph, find the deepest pit and provide the 
depth as per the specifications below.

- A non-empty array A consisting of N integers is given. A pit in this array is any triplet of integers (P, Q, 
R) such that: 0 ≤ P > Q < R;


- sequence [A[P], A[P+1], ..., A[Q]] is strictly decreasing,
i.e. A[P] > A[P+1] = A[Q];

- sequence A[Q], A[Q+1], ..., A[R] is strictly increasing,
i.e. A[Q] < A[Q+1] = A[R].

- The depth of a pit (P, Q, R) is the number min{A[P] − A[Q], A[R] − A[Q]}.

- N is an integer within the range [1..1,000,000];

- Each element of array A is an integer within the range [−100,000,000..100,000,000].

- Only count the pit if the decline started above ground i.e., 0

- Only count it as a pit if the decline is uninterrupted until the lowest point is reached (No flat line)

 - You stop counting when the water reaches the first ridge

- The response must be -1 if there is no pits found in the provided array
Example
Given the below series of co-ordinates (each value plotting the Y position on the next X axis) what is 
the deepest pit based on the requirements specified.

- 0 1 3 -2 0 1 0 -3 2 3
- Triplet (2, 3, 4) is one of pits in this array, because sequence [A[2], A[3]] is strictly decreasing (3 > −2) 
and sequence [A[3], A[4]] is strictly increasing (−2 < 0). Its depth is min{A[2] − A[3], A[4] − A[3]} = 2. 

- Triplet (2, 3, 5) is another pit with depth 3. Triplet (5, 7, 8) is yet another pit with depth 4. There is no 
pit in this array deeper (i.e., having depth greater) than 4.

# Definition of Done 
- Complete the solution in the QuestionTwo.cs class using GetPitDepth(int[] points) method
-  Add another unit test for “1, 2, 3, 1, 2, 3, 1, 2, 3”. This should return 2
