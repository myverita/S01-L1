#include <iostream>
#include <string>

using namespace std;

class LinkSocial {
private:
    string nome;
    string arcana;
    int rank;

public:
    string getNome() {
        return nome;
    }

    string getArcana() {
        return arcana;
    }

    int getRank() {
        return rank;
    }

    void setNome(string nome) {
        this->nome = nome;
    }

    void setArcana(string arcana) {
        this->arcana = arcana;
    }

    void setRank(int rank) {
        this->rank = rank;
    }

    void subirRank() {
        rank++;
    }
};

int main() {
    LinkSocial link;
    link.setNome("Fulano");
    link.setArcana("Mundo");
    link.setRank(1);

    cout << "Rank inicial: " << link.getRank() << endl;
    link.subirRank();
    cout << "Rank final: " << link.getRank() << endl;

    cout << "\ndados" << endl;
    cout << "Nome: " << link.getNome() << endl;
    cout << "Arcana: " << link.getArcana() << endl;
    cout << "Rank: " << link.getRank() << endl;

    return 0;
}
