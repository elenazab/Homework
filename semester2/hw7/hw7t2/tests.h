#include <QtCore/QtCore>
#include <QtTest/QtTest>
#include "uniquelist.h"

class Tests : public QObject
{
    Q_OBJECT
public:
    explicit Tests(QObject *parent = 0):QObject(parent){}

private slots:
    void init()
    {
        O = new UniqueList<int>();
    }

    void testAdd1()
    {
        try{
        O->add(1);
        O->add(1);
        }
        catch (ExeptionAdd)
            {
            QWARN("ExeptionAdd ok");
            }
    }

    void testAdd2()
    {
        try{
        O->add(1);
        O->add(2);
        }
        catch (ExeptionAdd)
            {
            QVERIFY(1!=1);
            }
    }

    void testDel1()
    {
        try{
            O->del(16);
        }
        catch (ExeptionDel)
        {
            QWARN("ExeptionDel ok");
        }
    }

    void testDel2()
    {
        try{
            O->add(1);
            O->del(1);
        }
        catch (ExeptionDel)
        {
            QVERIFY(1!=1);
        }
    }

private:
    UniqueList<int> *O;
};
