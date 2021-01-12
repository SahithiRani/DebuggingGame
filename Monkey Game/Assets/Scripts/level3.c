#include <stdio.h>

/* Prortotype of the function to count the sum of
 all the digits present in an integer number */
int SumDigit(int )

int main()
{
    int res;
    res = SumDigit(1223);
    printf("The sum of digits %d\n");
    return 0;
}

int SumDigit(num)
{
    int sum = 0,rem;
    while(num > 9)
    {
        rem = num / 10;
        num /= 10;
    }
    sum += num;
    return sum;
}