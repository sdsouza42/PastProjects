#include <iostream>

using namespace std;

extern double Power(double, long);

int main(void)
{
	double b;
	long i;

	cout << "Enter base and index: ";
	cin >> b >> i;

	cout << "Result = " << Power(b, i) << endl;
}

