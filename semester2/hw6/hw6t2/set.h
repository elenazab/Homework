#pragma once
#include <cstdlib>
#include "SetElement.h"

template<typename T>
class Set
{
public:
    Set();
    ~Set();
    void add(T x);
    void del(T x);
    bool exist(T x);
    void unionOfSet(Set<T> *y);
    void intersectionOfSet(Set<T> *y);
private:
    SetElement<T> *head;
};

template<typename T>
Set<T>::Set()
    :head(new SetElement<T>)
{}

template<typename T>
Set<T>::~Set()
{
    while (head->getNext != NULL)
    {
        SetElement<T> *tmp = head->getNext();
        head->setNext(head->getNext()->getNext());
        delete tmp;
    }
    delete head;
}

template<typename T>
void Set<T>::add(T x)
{
    SetElement<T> * tmp = new SetElement <T>(x, NULL);
    tmp->setNext(head->getNext());
    head->setNext(tmp);
}

template<typename T>
void Set<T>::del(T x)
{
    if (this->exist(x))
    {
        SetElement<T> *tmp = head;
        while (tmp->getNext()->getValue() != x)
        {
            tmp = tmp->getNext();
        }
        SetElement<T> *tmp2 = tmp->getNext();
        tmp->setNext(tmp2->getNext());
        delete tmp2;
    }
}


template<typename T>
bool Set<T>::exist(T x)
{
    SetElement<T> *tmp = head;
    while(tmp->getNext())
    {
        tmp = tmp->getNext();
        if (tmp->getValue() == x)
            return true;
    }
    return false;
}

template<typename T>
void Set<T>:: unionOfSet(Set<T> *y)
{
    SetElement<T> *tmp = y->head;
    while (tmp->getNext())
    {
        tmp = tmp->getNext();
        this->add(tmp->getValue());
    }
}

template<typename T>
void Set<T>:: intersectionOfSet(Set<T> *y)
{
    SetElement<T> *tmp = this->head;
    while (tmp->getNext())
    {
        SetElement<T> *tmp2 = tmp;
        tmp = tmp->getNext();
        if (!y->exist(tmp->getValue()))
        {
            tmp2->setNext(tmp->getNext());
            this->del(tmp->getValue());
            tmp = tmp2;
        }
    }
}
