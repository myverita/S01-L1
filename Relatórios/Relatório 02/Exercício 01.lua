print("DIGITE O EXPOENTE INICIAL")

local exp1 = tonumber(io.read())

print("DIGITE O EXPOENTE FINAL")

local exp2 = tonumber(io.read())

print("DIGITE A BASE")

local base = tonumber(io.read())

if exp1 and exp2 then 
    for i = exp1, exp2 do
        local resul = base ^ i
        print(base.. " ^ " .. i .. " = " .. resul)
    end
else
    print("ENTRADA INVALIDA")
end
