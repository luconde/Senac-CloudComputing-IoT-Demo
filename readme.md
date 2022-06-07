# Visão Geral
Este projeto tem o propósito de simular um dispositivo IoT que conecta no Azure IoT Hub e foi montado para as aulas de Computação em Nuvem e Internet das Coisas no curso Tecnologias para Sistemas de Internet nas Faculdades Senac em 2022.

# Autor
Luciano Condé de Souza (luconde@gmail.com)
Data: 2022-05-26

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
