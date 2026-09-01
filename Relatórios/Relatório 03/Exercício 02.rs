use std::io;

fn acertou_o_alvo(palpite: i32, numse: i32) -> bool {
    let dif = (palpite - numse).abs();
    if dif <= 5 {
        return true;
    }
    return false
}

fn main() {
    let numse: i32 = 13;
    loop {
        let mut palpite = String::new();
        println!("Digite seu palpite:");
        io::stdin().read_line(&mut palpite).unwrap();
        let palpite: i32 = palpite.trim().parse().unwrap();
        if acertou_o_alvo(palpite, numse) {
            let dist = (palpite - numse).abs();
            println!(
                "Parabens, voce acertou o alvo! Voce ficou a apenas {} unidade(s) do numero secreto.",
                dist
            );
            break;
        } else {
            println!("Voce passou longe! Tente novamente.");
        }
    }
}
