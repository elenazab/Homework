#include <iostream>
using namespace std;

void bin(unsigned char *p, char string[], int j)
{
	int dec = *p;
	for(int i = 0; i < 8; i++)
	{
		string[j] = '0' + dec - dec/2*2;
		dec /= 2;
		j--;
	}
}

int decimal(char string[])
{
	int r = 1;
	int result = 0;
	for(int i = 11; i > 0; i--)
	{
		if(string[i] == '1')
			result = result + r;
		r *= 2;
	}
	return result;
}

double dec(char string[])
{
	double r = 0.5;
	double result = 1.0;
	for(int i = 12; i < 64; i++)
	{
		if(string[i] == '1')
			result = result + r;
		r /= 2;
	}
	return result;
}


void print(char string[])
{
	if (string[0] == '0')
		printf("+%f*2^(%d)", dec(string), decimal(string) - 1023);
	else
		printf("-%f*2^(%d)", dec(string), decimal(string) - 1023);
}

int main()
{
	double var = 0.0;
	cin >> var;
	char string[65];
	unsigned char *p = (unsigned char*)(&var);
	int j = 7;
	for(int i = 7; i >= 0; i--)
	{
		bin((p + i), string, j);
		j += 8;
	}
	string[64] = '\0';
	j = 63;
	while((string[j] != '1') && (j > 11))
	{
		string[j] = '\0';
		j--;
	}	
	print(string);
	cin >> var;
	return 0;
}