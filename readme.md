# Visão Geral
Este projeto tem o propósito de simular um dispositivo IoT que conecta no Azure IoT Hub e foi montado para as aulas de Computação em Nuvem e Internet das Coisas no curso Tecnologias para Sistemas de Internet nas Faculdades Senac em 2022.

Projeto construído para a disciplina **Cloud Computing e Internet das Coisas** do curso **Tecnologia em Sistemas para Internet (TSI) do Senac-SP**.

# Autor
**Luciano Condé de Souza (luconde@gmail.com)**  
**Data da criação do projeto**: 2022-05-26  
**Data da última atualização**: 2023-06-02  
**Versão**: 1.0.10

## Disclaimer
O seguinte material foi construído a partir de referências publicadas na Internet, livros e artigos acadêmicos. As referências foram utilizadas de sites e posts na Internet, não há qualquer propósito de plagiar os autores, em caso de pedidos de adição do autor, pode encontrar em contato pelo email luconde@gmail.com. A simplificação de certos conteúdos tem o único propósito didático para facilitar o entendimento dos mesmos para os alunos.

# Notas da versão 
## Versão 1.0.10
1. Pasta **scripts** para armazenamento dos scripts Powershell para administração do ambiente
2. Pasta **src** para ter o código-fonte do projeto
3. Movimentação do código-fonte para dentro da pasta **src**
4. Atualização e ajustes do arquivo README.md
5. Tagging para ter mais controle da evolução do código-fonte

# Detalhes técnicos

## Funcionalidades
1. Dispositivo simulado em .NET Windows Forms
2. Conecta no Azure IoT Hub e envia mensagens para envia a temperatura, umidade e alerta de temperatura
3. Tem um método para receber mudanças no gatilho de alerta de temperatura

## Pré-requisitos
1. Hub no Azure IoT Hub
2. Uso do Azure IoT Explorer para fazer telemetria e também "invoke method"
3. Uso do Azure Storage Explorer para ler os storage em caso de alerta 
4. Subscription Ativa do Microsoft Azure
5. Visual Studio 2022 Community para executar o código-fonte

# Informações adicionais

