#pragma once
#include <QVector>
#include "iostream"

using namespace std;

int const size = 3;

template <typename T>
class Vyvodilka
{
public:
    Vyvodilka();
    ~Vyvodilka();
    virtual void vyvesty(T x) = 0;
};


template <typename T>
Vyvodilka<T>::Vyvodilka()
{
}

template <typename T>
Vyvodilka<T>::~Vyvodilka()
{
}
