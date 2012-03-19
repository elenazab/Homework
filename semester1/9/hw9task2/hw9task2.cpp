#include <iostream>
#include <string>

using namespace std;

void clear(char string[])
{
	for (int i = 0; i < 1000; i++)
	{
		string[i] = '\n';
	}	
}

bool isSubstring(string sub, char *str, int s, int int_sub)
{
	for (int i = 0; i < int_sub; i++)
	{
		if( sub[i] != str[i+s])
			return false;
	}
	return true;
}


int main()
{
	char *str = new char[1000];
	clear(str);
	string sub;
	cout << "enter substring\n";
	getline(cin, sub);
	int hash = 0;
	int int_sub = sub.length();
	for (int i = 0; i < int_sub; i++)
		hash = hash + sub[i];

	FILE *file;
	file = fopen("text.txt", "r");
	int k = 0;
	while (!feof(file))
	{
		str[k] = fgetc(file);
		k++;
	}

	int hashStr = 0;
	

	for (int j = 0; j < int_sub; j++)
		hashStr += str[j];
		

	int s = 0;

	while (str[s+int_sub-1] != '\n')
	{
		if (hash == hashStr)
		{
			if (isSubstring(sub, str, s, int_sub))
				cout << s+1 << "\n";
		}
		
		hashStr -= str[s];
		hashStr += str[s+int_sub];
		s++;
		
	}
	cin >> s;

	fclose(file);
	return 0;
}



