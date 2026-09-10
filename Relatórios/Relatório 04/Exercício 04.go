package main

import "fmt"

func validarIngresso(setor string, codigo int) bool {
	if setor == "VIP" && codigo == 2026 {
		return true
	} else {
		return false
	}
}

func main() {
	var setor string
	var cod int
	var valido bool
	for {
		fmt.Print("Digite o setor do ingresso: ")
		fmt.Scan(&setor)
		fmt.Print("Digite o codigo do ingresso: ")
		fmt.Scan(&cod)
		valido = validarIngresso(setor, cod)
		if valido == true {
			fmt.Println("Acesso liberado a area VIP")
			break
		} else {
			fmt.Println("Ingresso ou setor invalido. Tente novamente.")
		}
	}
}

