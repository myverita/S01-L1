package main
import "fmt"

func gerarEscalaPlantao(n int) {
	fmt.Println("escala de plantão tecnico")
	dia := 1
	for i := 1; i <= n; i++ {
		fmt.Println("Plantao", i, ": dia", dia, "do mes")
		dia = dia + 4
	}
}

func main() {
	var quant int
	fmt.Print("Digite a quantidade de plantões necessários: ")
	fmt.Scan(&quant)
	gerarEscalaPlantao(quant)
}
