int const size = 23;
struct List
{
	List *next;
	char data[size];
	int value;
};
List** create();
void deleteList(List *x);
void clear(char *str);
bool equiv(char *str1, char *str2);
int h(char *str);
void add(char *str, List **hash);
List *find (char *str, List **hash);
void del (char *str, List **hash);
