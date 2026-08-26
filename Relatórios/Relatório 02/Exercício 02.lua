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

print("DIGITE O NUMERO A SER BUSCADO")

local buscar = tonumber(io.read())

function contarOcorrencias(tabela, alvo)
    local ocorr = 0
    for i = 1, #tabela do
        if tabela[i] == alvo then
            ocorr = ocorr + 1
        end
    end
    return ocorr
end

local resul = contarOcorrencias(tabela1, buscar)

print("O NUMERO " .. buscar .." APARECE " .. resul .. " VEZES NA TABELA")
