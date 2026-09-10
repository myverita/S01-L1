package main

import "fmt"

func main() {

	var venda1 int
	var venda2 int
	var venda3 int
	var total int

	fmt.Print("Digite as vendas do 1 trimestre: ")
	fmt.Scan(&venda1)
	fmt.Print("Digite as vendas do 2 trimestre: ")
	fmt.Scan(&venda2)
	fmt.Print("Digite as vendas do 3 trimestre: ")
	fmt.Scan(&venda3)
	total = venda1 + venda2 + venda3

	if total < 100 {
		fmt.Println("Meta mínima anual nao atingida")
	} else {
		fmt.Println("Total de vendas:", total, "unidades")
		switch {
		case total >= 250:
			fmt.Println("Classificação: Categoria Top Seller")
		case total >= 180:
			fmt.Println("Classificação: Categoria Sênior")
		case total >= 100:
			fmt.Println("Classificação: Categoria Pleno")
		}
	}
}
