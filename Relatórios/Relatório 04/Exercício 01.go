package main
import "fmt"

func ValidarCodigoRastreio(codigo string) (bool, string) {
	if len(codigo) == 10 {
		return true, "Código de rastreio registrado no sistema!"
	} else {
		return false, "Erro: O código de rastreio deve ter exatamente 10 caracteres."
	}
}

func main() {
	var cod string
	var val bool
	var msgm string
	for val == false {
		fmt.Print("Digite o código de rastreio: ")
		fmt.Scan(&cod)
		val, msgm = ValidarCodigoRastreio(cod)
		fmt.Println(msgm)
	}
}
