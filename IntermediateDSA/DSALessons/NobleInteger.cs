/*
 An element ar[i] is called a noble element if the number of elements is equal to ar[i].

 Find the count of such noble elements.
 
 Example:

    A = {1 ,-5, 3, 5, -10, 4}

 Count of elements less than each element of the array looks like this:

       {2, 1, 3, 5, 0, 4}

 2 because there are 2 elements less than 1 and they are: -5, -10

 1 because there are 1 element less than -5 and they are -10

 3 because there are 3 elements less than 3 and they are -5, -10, 1

 5 because there are 5 elements less than 5 and they are -5, -10, 1, 3, 4

 0 because there are no elements less than -10 and they are none as there are no elements less than -10

 4 because there are 4 elements less than 4 and they are -5, -10, 1, 3

 */