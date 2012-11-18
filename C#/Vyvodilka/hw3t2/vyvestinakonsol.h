#pragma once
#include "iostream"
#include "vyvodilka.h"

using namespace std;

template <typename T>
class VyvestiNaKonsol: public Vyvodilka<T>
{
public:
    VyvestiNaKonsol();
    ~VyvestiNaKonsol();
     virtual void vyvesty(T x);
};

template <typename T>
void VyvestiNaKonsol<T>::vyvesty(T x)
{
    cout << x << " ";
}

template <typename T>
VyvestiNaKonsol<T>::VyvestiNaKonsol()
{
}

template <typename T>
VyvestiNaKonsol<T>::~VyvestiNaKonsol()
{
}
