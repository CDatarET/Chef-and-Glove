# Chef-and-Glove
CodeChef Difficulty 1104 Problem. 

Chef and Glove Fit
Problem Statement
Winter has finally come to Chefland, so Chef bought a glove for herself.

Chef has a hand with N fingers (including the thumb), numbered from 1 to N, and the glove has N sheaths, also numbered from 1 to N. Each finger must be inserted into exactly one sheath.

You are given:

The lengths of Chef's fingers, in left-to-right order.

The lengths of the sheaths of the glove, as seen from the front (left-to-right).

Chef can wear the glove in two ways:

Front orientation: Each finger goes into the sheath at the same index (i.e., finger i into sheath i).

Back orientation (glove flipped): Finger i goes into sheath N + 1 - i.

Chef can wear the glove only if the length of each finger is less than or equal to the length of the corresponding sheath.

Objective
Determine whether Chef can wear the glove:

In the front orientation only → output front

In the back orientation only → output back

In both orientations → output both

In neither orientation → output none

Input
First line: A single integer T – the number of test cases

For each test case:

First line: An integer N – the number of fingers

Second line: N space-separated integers – lengths of the fingers

Third line: N space-separated integers – lengths of the glove sheaths (from the front view)

Output
For each test case, print one line containing one of the strings:

front
back
both
none
