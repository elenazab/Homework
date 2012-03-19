struct Tree
{
	char value;
	Tree *left;
	Tree *right;
};

Tree *createTree();
void printTreeAsc(Tree *t);
//void printTreeDes(Tree *t);
void add (Tree *t, char value);
bool exists(Tree *t, char value);
int deleteMin(Tree *&t);
void deleteElement(Tree *&t, int value);
void deleteTree(Tree *t);