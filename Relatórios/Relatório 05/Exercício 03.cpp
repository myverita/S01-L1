#include <iostream>
using namespace std;

int main() {
    float capmax;
    float carga_atual = 0.0;
    int opcao;

    cout << "Informe a capacidade maxima de carga do drone (kg): ";
    cin >> capmax;

    do {
        cout << "=== SISTEMA DE CARGA DO DRONE ===" << endl;
        cout << "1. Verificar Carga" << endl;
        cout << "2. Carregar Pacote" << endl;
        cout << "3. Descarregar Pacote" << endl;
        cout << "4. Encerrar Operacao" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                cout << "Carga Atual: " << carga_atual << " kg / " << capmax << " kg" << endl;
                cout << "Espaco Disponivel: " << (capmax - carga_atual) << " kg" << endl;
                break;
            }

            case 2: {
                float peso_pacote;
                cout << "Digite o peso do pacote a ser carregado (kg): ";
                cin >> peso_pacote;

                if (carga_atual + peso_pacote > capmax) {
                    cout << "Alerta: Peso maximo de decolagem excedido! Operacao cancelada." << endl;
                } else {
                    carga_atual = carga_atual + peso_pacote;
                    cout << "Pacote adicionado com sucesso!" << endl;
                }
                break;
            }

            case 3: {
                float peso_remover;
                cout << "Digite o peso a ser removido (kg): ";
                cin >> peso_remover;

                if (peso_remover > carga_atual) {
                    cout << "Alerta: Nao e possivel remover mais peso do que o carregado." << endl;
                } else {
                    carga_atual = carga_atual - peso_remover;
                    cout << "Pacote removido com sucesso!" << endl;
                }
                break;
            }

            case 4: {
                cout << "Encerrando sistema de telemetria..." << endl;
                break;
            }

            default: {
                cout << "Opcao invalida! Tente novamente." << endl;
                break;
            }
        }

    } while (opcao != 4);

    return 0;
}
