Dim peso As Integer
Dim agua As Integer
Dim rec As Integer

Print "DIGITE SEU PESO: "
Input peso
Print  "QUANTOS ML DE AGUA VOCE JA BEBEU HOJE?"
Input agua

rec = peso * 35
If agua >= rec Then
    Print "META ATINGIDA!"
Else 
    Print "META NAO ATINGIDA!"
End If


Sleep
