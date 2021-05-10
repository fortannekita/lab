#include <iostream>
#include <string>
 
using namespace std;
 
class Clothing
{
    public:
    string size;
    string material;
    int price;
};

Clothing object[10];
    int c, d;
    int loop = 1;
    int menu = 10;
class Fill: public Clothing
{
    public:
    void fill_array(void)
    {
       for(int i = 0; i < 10; i++)
        {
            cout << "Introduceti marimea hainei nr: " << i + 1 << endl;
            cin >> object[i].size;
            cout << "Introduceti materialul hainei nr: " << i + 1 << endl;
            cin >> object[i].material;
            cout << "Introduceti pretul hainei nr: " << i + 1 << endl;
            cin >> object[i].price;
        }
    }
};

class Show: public Clothing
{
    public:
    void show_array(void)
    {
       for(int i = 0; i < 10; i++)
        {
            cout << "Parametrii hainei nr: " << i + 1 << endl;
            cout << "Marimea: " << object[i].size << endl;
            cout << "Materialul: " << object[i].material << endl;
            cout << "Pretul: " << object[i].price << endl;
        } 
    }
};

class Sort: public Clothing
{
    public:
    void sort_array(void)
    {
       static Clothing swap;
        for(c = 0; c < 10; c++)
        {
            for(d = 0; d < 10 - c; d++)
            {
                if (object[d].price > object[d + 1].price)
                {
                    swap = object[d];
                    object[d] = object[d + 1];
                    object[d + 1] = swap;
                }
            }
        }
        cout << "Lista sortata dupa pret" << endl;
        for(int i = 0; i < 10; i++)
        {
            cout << "Parametrii hainei nr: " << i + 1 << endl;
            cout << "Marimea: " << object[i].size << endl;
            cout << "Materialul: " << object[i].material << endl;
            cout << "Pretul: " << object[i].price << endl;
        }
    }
};

int main()
{
    Show show_var;
    Fill fill_var;
    Sort sort_var;
    cout << "0 - iesire din program" << endl;
    cout << "1 - introducere date" << endl;
    cout << "2 - afisare date" << endl;
    cout << "3 - sortare date" << endl;
    while(loop)
    {
        cin >> menu;
        if (menu != 10)
        cout << string (50, '\n');
        switch(menu)
        {
            case 0:
                loop = 0;
            break;
            case 1:
                fill_var.fill_array();
            break;
            case 2:
                show_var.show_array();
            break;
            case 3:
                sort_var.sort_array();
            break;
            default:
                cout << "Comanda gresita!" << endl;
            break;
        }
        if (menu != 10)
        {
            cout << endl;
            cout << "0 - iesire din program" << endl;
            cout << "1 - introducere date" << endl;
            cout << "2 - afisare date" << endl;
            cout << "3 - sortare date" << endl;
            cout << endl;
        }
        menu = 10;
    }
    return 0;
}
