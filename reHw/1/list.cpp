#include "list.h"
#include <iostream>
using namespace std;

List :: add( int x)
{
    ListElement * tmp = new ListElement (x, NULL);
    tmp->setNext(head->getNext());
    head->setNext(tmp);
}

List :: ~List()
{
    while (head->getNext != NULL)
    {
        ListElement *tmp = head;
        head->setNext(head->getNext());
        delete tmp;
    }
    delete head;
}

List ::valueHead()
{
    return head->setValue();
}

List :: print()
{
    ListElement * tmp = head;
    while (tmp->getNext() != NULL)
    {
        tmp->setNext(tmp->getNext());
        cout << tmp->setValue();
    }
}


