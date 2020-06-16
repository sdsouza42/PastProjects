#include <stdio.h>

double Average(double first, double second, double* deviation)
{
	*deviation = first > second ? (first - second) / 2 : (second - first) / 2;
	return (first + second) / 2;
}

int main(void)
{
	double x, y, a, d;

	printf("Enter two real values: ");
	scanf("%lf%lf", &x, &y);

	a = Average(x, y, &d);

	printf("Average = %lf with deviation of %lf\n", a, d);
}

