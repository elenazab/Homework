#pragma once
#include <cstdlib>
#include "listelement.h"

template<typename T>
class List
{
public:
    List();
    ~List();
    virtual void add(T x);
    virtual void del(T x);
    bool exist(T x);
private:
    ListElement<T> *head;
};

template<typename T>
List<T>::List()
    :head(new ListElement<T>)
{}

template<typename T>
List<T>::~List()
{
    while (head->getNext() != NULL)
    {
        ListElement<T> *tmp = head->getNext();
        head->ListNext(head->getNext()->getNext());
        delete tmp;
    }
    delete head;
}

template<typename T>
void List<T>::add(T x)
{
    ListElement<T> * tmp = new ListElement <T>(x, NULL);
    tmp->ListNext(head->getNext());
    head->ListNext(tmp);
}

template<typename T>
void List<T>::del(T x)
{
    if (this->exist(x))
    {
        ListElement<T> *tmp = head;
        while (tmp->getNext()->getValue() != x)
        {
            tmp = tmp->getNext();
        }
        ListElement<T> *tmp2 = tmp->getNext();
        tmp->ListNext(tmp2->getNext());
        delete tmp2;
    }
}


template<typename T>
bool List<T>::exist(T x)
{
    ListElement<T> *tmp = head;
    while(tmp->getNext())
    {
        tmp = tmp->getNext();
        if (tmp->getValue() == x)
            return true;
    }
    return false;
}
