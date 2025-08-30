Desafio de Projeto - Sistema de Estacionamento

Este projeto faz parte do desafio de fundamentos da trilha .NET da DIO, com o objetivo de aplicar conceitos de programação orientada a objetos (POO), coleções e manipulação de console.

Agradeço ao professor Leonardo Buta por fornecer o desafio e o repositório base que impulsionaram este projeto.

Repositório Original do Professor Leonardo Buta: https://github.com/leonardo-buta/trilha-net-fundamentos-desafio.git

LinkedIn do Professor: https://www.linkedin.com/in/leonardo-buta/

🚀 Tecnologias e Ferramentas
Linguagem: C#

Framework: .NET 8

Editor: Visual Studio Code

Controle de Versão: Git e GitHub

🛠️ Como o Projeto Foi Construído
O desenvolvimento deste projeto foi uma jornada de aprendizado prático, focando na aplicação direta de fundamentos do C#. A estrutura do projeto é composta por uma classe principal Estacionamento e a lógica de execução no Program.cs.

1. Estrutura do Projeto
O projeto segue uma estrutura básica de console, com a classe Estacionamento localizada na pasta Models, responsável por toda a lógica de negócio (adicionar, remover e listar veículos). O arquivo Program.cs atua como o ponto de entrada, onde o menu interativo é implementado para que o usuário possa interagir com o sistema.

2. Resolução de Problemas
Durante o processo de desenvolvimento, enfrentei desafios de configuração que serviram como valiosos aprendizados. Inicialmente, o projeto, configurado para o .NET 6, não estava executando corretamente na minha máquina, que já possuía o SDK do .NET 8.

A solução técnica foi atualizar o arquivo .csproj do projeto, alterando a tag <TargetFramework> de net6.0 para net8.0. Essa pequena, mas crucial, alteração permitiu que o projeto fosse compilado e executado com o framework mais recente, garantindo a compatibilidade.

Além disso, problemas de "caminho de diretório não encontrado" foram resolvidos executando os comandos dotnet run e dotnet restore a partir da pasta correta do projeto, garantindo que o terminal pudesse localizar o arquivo .csproj e suas dependências.

✨ Funcionalidades do Sistema
O sistema de estacionamento oferece as seguintes funcionalidades no console:

Cadastrar Veículo: Permite que o usuário insira a placa de um veículo, que é então adicionada a uma lista interna.

Remover Veículo: Solicita a placa e a quantidade de horas que o veículo permaneceu estacionado. Em seguida, calcula e exibe o valor total a ser pago.

Listar Veículos: Exibe todos os veículos que estão atualmente estacionados.

Encerrar: Finaliza a execução do programa.

🔗 Links

Meu Repositório do Projeto: [github.com/marcio-gil/EstacionamentoApp]

Meu LinkedIn: [linkedin.com/in/márcio-gil-1b7669309]