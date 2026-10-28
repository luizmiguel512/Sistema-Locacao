# Sistema de Locação

Sistema de locação de veículos que recomenda ao cliente a categoria de carro mais adequada a partir da necessidade que ele relata. Hoje a recomendação funciona por regras e palavras-chave, e a ideia é evoluí-la para IA via API.

## Sobre

Esse sistema surge da percepção de uma necessidade real de clientes reais.

A ideia principal é ajudar clientes com pouca experiência com veículos a escolher a melhor opção. Por exemplo: o cliente relata que vai pegar uma estrada de terra, e o sistema recomenda um 4x4.

## Módulos

- [x] Modelos de domínio (Clientes, Veículos, Locação)
- [x] Recomendação de categoria de veículo pelo relato do cliente (versão inicial baseada em regras e palavras-chave)
- [ ] Integração entre módulos via API

## Tecnologias

- C# / .NET

## Como rodar

dotnet run --project SistemaLocacao2.dominio


## Próximos passos

Evoluir a recomendação, que hoje usa palavras-chave, para utilizar Inteligência Artificial via API.

## Autor

Luiz Miguel Caetano Machado
https://www.linkedin.com/in/luiz-miguel-caetano-machado-68130917a/