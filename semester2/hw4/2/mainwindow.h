#pragma once

#include <QMainWindow>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    int calc(int a, int b, char operation);

private:
    Ui::MainWindow *ui;

public slots:
    void changed();
};


