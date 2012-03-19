#include <iostream>
using namespace std;

int fact(int a)
{
	if(a==1)
		return 1;
	else
		return a * fact(a-1);
}

int main()
{
	int a = 0;
	cout << "enter a\n";
	cin >> a;
	int i = 0;
	if(a==0)
		a = 1;
	for(i = (a - 1); i > 1; i--)
	{
		a = a * i;
	}
	cout << a << "\n";
	cout << "enter a\n";
	cin >> a;
	cout << fact(a);
	cin >>a;

}
