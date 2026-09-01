use std::io;

fn imprimir_terminados_em(digito: i32, limite_inferior: i32, limite_superior: i32) {
    for num in limite_inferior..=limite_superior {
        if num % 10 == digito {
            println!("{}", num);
        }
    }
}

fn main() {
    let mut dig = String::new();
    let mut liminf = String::new();
    let mut limsup = String::new();
    println!("Digite o digito final desejado (0 a 9):");
    io::stdin().read_line(&mut dig).unwrap();
    println!("Digite o limite inferior:");
    io::stdin().read_line(&mut liminf).unwrap();
    println!("Digite o limite superior:");
    io::stdin().read_line(&mut limsup).unwrap();
    let dig: i32 = dig.trim().parse().unwrap();
    let liminf: i32 = liminf.trim().parse().unwrap();
    let limsup: i32 = limsup.trim().parse().unwrap();
    println!("--- Numeros no intervalo terminados em {} ---", dig);
    imprimir_terminados_em(dig, liminf, limsup);
}
