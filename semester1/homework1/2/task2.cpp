
#include <iostream>
using namespace std;

int main()
{
	int a,b;
	cin >> a;
	cin >> b;
	int i=0;
	while(a>b)
	{
		a=a-b;
		i=i+1;
	}
	cout << i;
	system("Pause");
	return 0;
}