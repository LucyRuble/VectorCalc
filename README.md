# Vector Calculator - Handout

### Points
110 (+40 pt. Extra Credit Opportunity)

---

### Due Date
February 7th, 2024

---

### Goal
To create a C# class capable of representing Vectors and performing the Vector operations that we learn about in class.

---
### Instructions
Start by creating a C# class that represents a 3D Vector. This must have an X, a Y, and a Z (think about what data type best represents these: An int? A float? A string? A bool? Could you use an array for this?). After you confirm that this works, create functions for each of the math concepts we learned about in class. If at any point you need help, please ask another student before asking me. Finally, each function must have comments explaining what's going on, as well as an example of the math concept in play.

---

### Grading Rubric
Your grade will be determined based on how well your code passes a number of tests. Each test that it passes is worth 2 points, with each test falling under a different category of Vector operation (magnitude, direction, addition, subtract, etc.). There will be 5 tests per function, so expect negative numbers and decimals too, not just positive integers. You may test your code any number of times before submission to figure out what you need to improve on before the project is due. Grading criteria are split into 2 categories, Mastery Goals and Stretch Goals. Once you have completed all the Mastery Goals, you are expected to work on the Stretch Goals. Stretch Goals are worth extra credit points.

#### [110 pts.] Mastery Goals
- [10] Magnitude
- [10] Direction
- [10] Addition
- [10] Negation
- [10] Subtraction
- [10] Scaling
- [10] Normalization
- [10] Dot Product
- [10] Cross Product
- [10] Angle Between
- [10] Projection

#### [+40 pts.] Stretch Goals
- [+10] Null Checking or use of structs to avoid null possibility.
- [+10] Use of properties to make retrieving values easier.
- [+10] Support for any sized Vector (2D, 3D, 4D, etc.)
- [+10] Operator overrides for Add, Invert, Subtract, Scale, and Equals

---

### Learning Targets
- Recognize vector quantities as having both magnitude and direction. Represent vector quantities by directed line segments, and use appropriate symbols for vectors and their magnitudes (e.g., v, |v|, ||v||, v).
- Find the components of a vector by subtracting the coordinates of an initial point from the coordinates of a terminal point.
- Solve problems involving velocity and other quantities that can be represented by vectors.
- Add vectors end-to-end, component-wise, and by the parallelogram rule. Understand that the magnitude of a sum of two vectors is typically not the sum of the magnitudes.
- Given two vectors in magnitude and direction form, determine the magnitude and direction of their sum.
- Understand vector subtraction v – w as v + (–w), where –w is the additive inverse of w, with the same magnitude as w and pointing in the opposite direction. Represent vector subtraction graphically by connecting the tips in the appropriate order, and perform vector subtraction component-wise.
- Represent scalar multiplication graphically by scaling vectors and possibly reversing their direction; perform scalar multiplication component-wise, e.g., as c(vx, vy) = (cvx, cvy).
- Compute the magnitude of a scalar multiple cv using ||cv|| = |c|v. Compute the direction of cv knowing that when |c|v ≠ 0, the direction of cv is either along v (for c > 0) or against v (for c < 0).
