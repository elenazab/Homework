#include <iostream>
using namespace std;

int main()
{
	int tickets = 0;
	for (int a = 0; a != 10; a++)
	{
		for (int b = 0; b != 10; b++)
		{
			for (int c = 0; c != 10; c++)
			{
				for (int d = 0; d != 10; d++)
				{
					for (int e = 0; e != 10; e++)
					{
						for (int f = 0; f != 10; f++)
						{
							if ((a + b + c) == (d + e + f))
								tickets +=1;
						}
					}
				}
			}
		}
	}
	cout << tickets;
	cin >> tickets;
}
					