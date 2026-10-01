#include <iostream>
#include <string>

using namespace std;

class MembroInatel {
protected:
    string nome;

public:
    void seApresentar() {
        cout << "Sou um membro da comunidade Inatel: "
             << nome << "." << endl;
    }
};

class Aluno : public MembroInatel {
private:
    string curso;
public:
    void setNome(string nome) {
        this->nome = nome;
    }
    void setCurso(string curso) {
        this->curso = curso;
    }
    void seApresentar() {
        cout << "Meu nome e " << nome
             << " e estudo no curso de " << curso << "." << endl;
    }
};

class Professor : public MembroInatel {
private:
    string disciplina;

public:
    void setNome(string nome) {
        this->nome = nome;
    }
    void setDisciplina(string disciplina) {
        this->disciplina = disciplina;
    }
    void seApresentar() {
        cout << "Meu nome e " << nome
             << " e leciono a disciplina de "
             << disciplina << "." << endl;
    }
};

int main() {
    Aluno aluno;
    Professor professor;


    aluno.setNome("Pedro");
    aluno.setCurso("engenharia de software");
    professor.setNome("Ruan");
    professor.setDisciplina("Paradigmas");
    aluno.seApresentar();
    professor.seApresentar();

    return 0;
}
