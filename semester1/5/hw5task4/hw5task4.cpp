#include <iostream>
//#include <stdio.h>
#include <string>
//#include <string.h>
using namespace std;

int const size = 10;

struct List
{
	List *next;
	char name[size];
	char phone[size];
};

void deleteList(List *x)
{
	if (x->next)
		deleteList(x->next);
	delete x;
}

bool isLetter(char c)
{
	return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
}

bool isDigit(char c)
{
	return c >= '0' && c <= '9';
}
void clear(char *str)
{
	for (int i = 0; i < size; i++)
		str[i] = ' ';
}

bool equiv(char *str1, char *str2)
{
	int i = 0;
	while(i < size)
	{
		if (str1[i] != str2[i])
			return false;
		i++;
	}
	return true;
}


void findName(char *str, List *head)
{
	bool eq = false;
	while(head->next && !(eq))
	{
		head = head->next;
		eq = equiv(str, head->phone);
	}
	if (eq)
	{
		for (int i = 0; i < size; i++)
			cout << head->name[i];
		cout << "\n";
	}
	else
		cout << "phone not found";	
}

void findPhone(char *str, List *head)
{
	bool eq = false;
	while(head->next && !(eq))
	{
		head = head->next;
		eq = equiv(str, head->name);
	}
	if (eq)
	{
		for (int i = 0; i < size; i++)
			cout << head->phone[i];
		cout << "\n";
	}
	else
		cout << "name not found";	
}



void write (List *head, FILE *file)
{
	int i = 0;
	while (head->next)
	{
		head = head->next;
		i = 0;
		while(i < size)
		{
			fprintf(file, "%c", head->name[i]);
			i++;
		}
		fprintf(file, " ");
		i = 0;
		while(i < size)
		{
			fprintf(file, "%c", head->phone[i]);
			i++;
		}
		fprintf(file, "\n");
	}
}



int main()
{
	FILE *file = fopen ("text.txt", "a+");
	List *head = new List;
	head->next = NULL;
	string a;

	while (!feof(file))
	{
		List *tmp = new List;
		tmp->next = head->next;
		head->next = tmp;
		tmp->name[0] = fgetc(file);
		while (!isLetter(tmp->name[0]) && !feof(file))
			tmp->name[0] = fgetc(file);
		for (int i = 1; i < size; i++)
				tmp->name[i] = fgetc(file);
		tmp->phone[0] = fgetc(file);
		while(!isDigit(tmp->phone[0]) && !feof(file))
			tmp->phone[0] = fgetc(file);
		for (int i = 1; i < size; i++)
				tmp->phone[i] = fgetc(file);
		if (isLetter(tmp->name[0]))
			tmp = tmp->next;
		else
		{
			head->next = tmp->next;
			delete tmp;
		}
	}
	int x = -1;	
	while (x!=0)
	{
		cout << "0-exit\n1-add name&phone\n2-find phone number\n3-find name\n4-save\n";
		cin >> x;
		getline(cin,a);
		if (x == 1)
		{
			List *tmp = new List;
			tmp->next = head->next;
			head->next = tmp;
			clear(tmp->name);
			clear(tmp->phone);
			cout << "name\n";
			string str1;
			getline (cin,str1);
			for (int i = 0; str1[i] != '\0'; i++)
				tmp->name[i] = str1[i];
			cout << "\n";
			cout << "phone\n";
			string str2;
			getline (cin,str2);
			for (int i = 0; str2[i] != '\0'; i++)
				tmp->phone[i] = str2[i];
			cout << "\n";
			tmp = tmp->next;
		}		
		if (x == 2)
		{
			cout << "name = \n";
			string str;
			getline (cin,str);
			char tmpStr[size];
			clear(tmpStr);
			for (int i = 0; str[i] != '\0'; i++)
				tmpStr[i] = str[i];
			findPhone (tmpStr, head);
		}
		if (x == 3)
		{
			cout << "phone = ";
			string str;
			getline (cin,str);
			char tmpStr[size];
			clear(tmpStr);
			for (int i = 0; str[i] != '\0'; i++)
				tmpStr[i] = str[i];
			findName(tmpStr, head);
		}
		if (x == 4)
			write(head, file);
	}
	deleteList(head);
	fclose(file);
}






