#pragma once
#include "list.h"
#include "exeption.h"

template<typename T>
class UniqueList: public List<T>
{
public:
    UniqueList();
    //~UniqueList();
    void add(T x);
    void del(T x);
};

template<typename T>
UniqueList<T>::UniqueList()
{}

template<typename T>
void UniqueList<T>::add(T x)
{
    if (this->exist(x))
        throw ExeptionAdd();
    else
        List<T>::add(x);
}

template<typename T>
void UniqueList<T>::del(T x)
{
    if (!this->exist(x))
        throw ExeptionDel();
    else
        List<T>::del(x);
}

