#pragma once
#include "vyvodilka.h"

template <typename T>
class Xodilka
{
public:
    Xodilka(Vyvodilka<T> *v);
    ~Xodilka();
    void obojty(T massiv[][size]);
private:
    Vyvodilka<T> *vyvod;
};

template <typename T>
Xodilka<T>::Xodilka(Vyvodilka<T> *v)
    :vyvod(v)
{
}

template <typename T>
Xodilka<T>::~Xodilka()
{
}

template <typename T>
void Xodilka<T>::obojty(T massiv[][size])
{
    int line = 1;
    int i = size / 2;
    int j = size / 2;
    vyvod->vyvesty(massiv[i][j]);
    do
    {
        if (line%2)
        {
            for (int k = 0; k < line; k++)
            {
                vyvod->vyvesty(massiv[i-1][j]);
                i--;
                if (i < 0) return;
            }
            for (int k = 0; k < line; k++)
            {
                vyvod->vyvesty(massiv[i][j+1]);
                j++;
                if (j >= size) return;
            }
        }
        if (!(line%2))
        {
            for (int k = 0; k < line; k++)
            {
                vyvod->vyvesty(massiv[i+1][j]);
                i++;
                if (i >= size) return;
            }
            for (int k = 0; k < line; k++)
            {
                vyvod->vyvesty(massiv[i][j-1]);
                j--;
                if (j < 0) return;
            }
        }
        line ++;
    } while (line < size);
}
