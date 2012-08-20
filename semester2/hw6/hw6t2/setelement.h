#pragma once

template<typename T>
class SetElement
{
public:
    SetElement();
    SetElement(T a, SetElement<T>*b);
    T getValue();
    SetElement * getNext();
    void setNext(SetElement<T> *a);
private:
    T value;
    SetElement * next;
};

template<typename T>
SetElement<T>::SetElement()
    :value(NULL), next(NULL)
{}

template<typename T>
SetElement<T>::SetElement(T a, SetElement *b)
    : value(a), next(b)
{}

template<typename T>
T SetElement<T>::getValue()
{
    return value;
}

template<typename T>
void SetElement<T>::setNext(SetElement *a)
{
    next = a;
}

template<typename T>
SetElement<T>* SetElement<T>::getNext()
{
    return next;
}
