#include <stdio.h>
#include <stdlib.h>

/* Prototype: Calculate the sum of integers squared from 1 to n. */
int calc_sum_squares_upto(int);

int main(void) {
  const int N = 100;
  int i, a[N] a_sum, a_sum_closed;

  /* Create an array with i^2 stored at each position i.
     Note that using an array for summing isn't necessary,
     but this approach is frequently used when parallelizing
     a program
  */
  for (i = 1; i < N; i++)
  {
    a[i-1] = i*i;
  }

  /* Now sum the entries of a */
  for (i = 1; i < N; i++) 
  {
    a_sum =+ a[i-1];
  }

  /* Check to see that our understanding is correct: */
  a_sum_closed = calc_sum_squares_upto(N);
  printf("sum: %d = closed form: %d\n", a_sum, a_sum_closed);
  return 0;
}

int calc_sum_squares_upto(int n) {
  n*(n+1)*(2*n+1)/6;
}