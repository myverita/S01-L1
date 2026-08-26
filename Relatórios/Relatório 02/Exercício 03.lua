local tabela1 = {}

print("DIGITE O TAMANHO DA TABELA")

local tamanho = tonumber(io.read())

print("DIGITE OS NUMEROS DA TABELA")

if tamanho then 
    for i = 1, tamanho do
        local novo = tonumber(io.read())
        table.insert(tabela1, novo)
    end
else
    print("ENTRADA INVALIDA")
end

print("DIGITE O NUMERO LIMITE")

local limi = tonumber(io.read())

function filtrarMaiores(tabela, limite)
    local tabela2 = {}
    for i = 1, #tabela do
        if tabela[i] > limite then
            table.insert(tabela2, tabela[i])
        end
    end
    return tabela2
end


local resul = filtrarMaiores(tabela1, limi)

print("ELEMENTOS MAIORES QUE " .. limi)

for i = 1, #resul do
    print(resul[i])
end

