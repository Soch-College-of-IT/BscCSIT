//Program to generate permutation
#include<conio.h>
#include<stdio.h>
int factorial(int n);
int main()
{
int n,r,i;
printf("Enter value of n and r\n");
scanf("%d%d",&n,&r);
printf("The permutation P(%d, %d) = %d\n",n,r,factorial(n)/(factorial(n-r)));
getch();
return 0;
}
int factorial(int n)
{
if(n<=1)
return 1;
else
return n*factorial(n-1);
}
