use std::io;

fn validar_placa(placa: &str) -> bool {
    let mut letras = 0;
    let mut nums = 0;
    for c in placa.chars() {
        if c.is_ascii_uppercase() {
            letras += 1;
        }
        if c.is_numeric() {
            nums += 1;
        }
    }
    if placa.len() >= 7 && letras >= 4 && nums >= 2 {
        return true;
    }
    return false;
}

fn main() {
    loop {
        let mut plac = String::new();
        println!("Digite a placa do veiculo:");
        io::stdin().read_line(&mut plac).unwrap();
        plac = plac.trim().to_string();
        if validar_placa(&plac) {
            println!("Placa cadastrada no sistema!");
            break;
        } else {
            println!("Placa invalida. Tente novamente!");
        }
    }
}
