Dim senha As Integer
Dim tentativa As Integer

senha = 1234
Print "DIGITE A SENHA: "
Input tentativa

If tentativa = senha Then
    Print "TRANSACAO AUTORIZADA!"
Else 
    While tentativa > senha
        Print "PIN INVALIDO. TENTE NOVAMENTE."
        Input tentativa
        If tentativa = senha Then
            Print "TRANSACAO AUTORIZADA!"
        End If
    Wend
    While tentativa < senha
        Print "PIN INVALIDO. TENTE NOVAMENTE."
        Input tentativa
        If tentativa = senha Then
            Print "TRANSACAO AUTORIZADA!"
        End If
    Wend
End If

Sleep
