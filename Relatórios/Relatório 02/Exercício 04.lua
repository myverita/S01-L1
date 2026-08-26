
function analisarNumeros(n1, n2, operacao)
    if operacao == "media" then
        return calcularMedia(n1, n2)
    elseif operacao == "maior" then
        return encontrarMaior(n1, n2)
    elseif operacao == "diferenca" then
        return calcularDiferencaAbsoluta(n1, n2)
    else
        print("OPERACAO INVALIDA")
    end
end

function calcularMedia(a, b)
    local med = (a + b)/2
    return med
end

function encontrarMaior(a, b)
    if a > b then
        return a 
    else 
        return b 
    end
end 

function calcularDiferencaAbsoluta(a, b)
    local diff = math.abs(a - b)
    return diff
end


print("DIGITE O PRIMEIRO NUMERO")
local num1 = tonumber(io.read())

print("DIGITE O SEGUNDO NUMERO")
local num2 = tonumber(io.read())

print("DIGITE A OPERACAO ('media', 'maior' ou 'diferenca')")
local op = io.read()

local resul = analisarNumeros(num1, num2, op)

print("RESULTADO: " .. resul)
