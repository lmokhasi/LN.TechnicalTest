# Technical Test
The latest technical seed project

### Question 1 – Longest Sentence

```
Get the highest word count in a single sentence from a string
containing one or more sentences.
```
Requirement

Find the sentence containing the largest number of words in the given text and count the number of
words it contains.

- The text is specified as a string S consisting of N characters: letters, spaces, dots (.), question
    marks (?) and exclamation marks (!).
- A sentence can be divided into words by splitting it at spaces. A sentence without words is
    valid, but a valid word must contain at least one letter.
- The length of S is within the range [1..100];
- String S consists only of letters (a−z, A−Z), spaces, dots (.), question marks (?) and
    exclamation marks (!).
- Do not be concerned around performance, it will only be assessed on accuracy.
- Remember to commit regularly

Example

Given S = "We test coders. Give us a try?", there are two sentences: "We test coders",
" Give us a try" The first sentence contains three words: "We", "test" and "coders". The
second sentence contains four words: "Give", "us", "a" and "try".

The answer for the example text is 4 (words).

Definition of Done

- Complete the solution in the QuestionOne.cs class using GetLongestSentance(string s)
    method
- Add another unit test for “Forget CVs..Save time. x x” this should

  
### Question 2 – Deepest Pit

```
If you where in a valley with hills and lakes (two dimensions),
how deep could the deepest single lake be?
```
Requirement

Given an array of coordinates that plot pits and hills on a graph, find the deepest pit and provide the
depth as per the specifications below.

- A non-empty array A consisting of N integers is given. A pit in this array is any triplet of integers (P, Q,
    R) such that
       o 0 ≤ P > Q < R;
       o sequence [A[P], A[P+1], ..., A[Q]] is strictly decreasing,
          _i.e. A[P] > A[P+1] = A[Q];_
       o sequence A[Q], A[Q+1], ..., A[R] is strictly increasing,
          _i.e. A[Q] < A[Q+1] = A[R]._
       o The depth of a pit (P, Q, R) is the number min{A[P] − A[Q], A[R] − A[Q]}.
- N is an integer within the range [1..1,000,000];
- Each element of array A is an integer within the range [−100,000,000..100,000,000].
- Only count the pit if the decline started above ground i.e., 0
- Only count it as a pit if the decline is uninterrupted until the lowest point is reached (No flat line)
- You stop counting when the water reaches the first ridge
- The response must be -1 if there is no pits found in the provided array

Example

Given the below series of co-ordinates (each value plotting the Y position on the next X axis) what is
the deepest pit based on the requirements specified.

#### 0 1 3 - 2 0 1 0 - 3 2 3

Triplet (2, 3, 4) is one of pits in this array, because sequence [A[2], A[3]] is strictly decreasing (3 > −2)
and sequence [A[3], A[4]] is strictly increasing (−2 < 0). Its depth is min{A[2] − A[3], A[4] − A[3]} = 2.
Triplet (2, 3, 5) is another pit with depth 3. Triplet (5, 7, 8) is yet another pit with depth 4. There is no
pit in this array deeper (i.e., having depth greater) than 4.
SA Reg No 2023/555828/07 | © Trade Shield (Pty) Limited

Definition of Done

- Complete the solution in the QuestionTwo.cs class using GetPitDepth(int[] points) method
- Add another unit test for “1, 2, 3, 1, 2, 3, 1, 2, 3”. This should return 2.
- Remember to commit frequently.
