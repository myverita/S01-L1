#include <iostream>
#include <string>

using namespace std;

class Banda {
public:
    string nome;
    int integrantes;
    float potenciaSom;
    int energia;
    void duelar(Banda &rival) {
        cout << nome << " esta duelando contra " << rival.nome << endl;
        rival.energia -= potenciaSom;
        cout << "A energia de " << rival.nome << " agora e: "
             << rival.energia << endl;
    }
};

int main() {
    Banda banda1;
    Banda banda2;

    banda1.nome = "Rolling Stones";
    banda1.integrantes = 2;
    banda1.potenciaSom = 40;
    banda1.energia = 100;

    banda2.nome = "Metallica";
    banda2.integrantes = 12;
    banda2.potenciaSom = 20;
    banda2.energia = 100;

    banda1.duelar(banda2);

    cout << "\n status" << endl;

    cout << "\nBanda: " << banda1.nome << endl;
    cout << "Integrantes: " << banda1.integrantes << endl;
    cout << "Potencia do som: " << banda1.potenciaSom << endl;
    cout << "Energia: " << banda1.energia << endl;

    cout << "\nBanda: " << banda2.nome << endl;
    cout << "Integrantes: " << banda2.integrantes << endl;
    cout << "Potencia do som: " << banda2.potenciaSom << endl;
    cout << "Energia: " << banda2.energia << endl;

    return 0;
}

