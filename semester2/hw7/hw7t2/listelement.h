#pragma once

template<typename T>
class ListElement
{
public:
    ListElement();
    ListElement(T a, ListElement<T>*b);
    T getValue();
    ListElement * getNext();
    void ListNext(ListElement<T> *a);
private:
    T value;
    ListElement * next;
};

template<typename T>
ListElement<T>::ListElement()
    :value(NULL), next(NULL)
{}

template<typename T>
ListElement<T>::ListElement(T a, ListElement *b)
    : value(a), next(b)
{}

template<typename T>
T ListElement<T>::getValue()
{
    return value;
}

template<typename T>
void ListElement<T>::ListNext(ListElement *a)
{
    next = a;
}

template<typename T>
ListElement<T>* ListElement<T>::getNext()
{
    return next;
}
