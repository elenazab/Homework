struct Tree
{
	int value;
	Tree *left;
	Tree *right;
};

Tree *createTree();
void add (Tree *t, int value);
bool exists(Tree *t, int value);
int deleteMin(Tree *&t);
void deleteElement(Tree *&t, int value);
