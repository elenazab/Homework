#include <iostream>
#include <string.h>
#include "hash.h"
#include <stdio.h>
using namespace std;
//int const size = 23;


int main()
{
	List **hash = create();		
	char s[size];
	gets (s);
	add (s, hash);
	
	for (int i = 0; i < size; i++)
		deleteList(hash[i]);
	delete []hash;
	return 0;
}







					
		
