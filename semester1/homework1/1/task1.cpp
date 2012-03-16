#include <stdio.h>
#include <iostream>
using namespace std;

int main()
{
	int a = 0;
	int x = 0;
	cout << "enter x:";
	cin >> x;
	a = x * x;
	x = (a + x) * (a + 1);
	cout << x;    
	getch();
	return 0;
}