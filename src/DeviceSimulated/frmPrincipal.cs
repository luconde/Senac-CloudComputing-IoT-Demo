using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Azure.Devices.Client;
using System.Text.Json;
using System.Threading;

namespace DeviceSimulated
{
    public partial class frmPrincipal : Form
    {
        #region APIs para o console
        //Usado para criar a tela de console
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();
        #endregion

        #region Membros privados da classe
        /// <summary>
        /// Membros privados
        /// </summary>
        private bool mblnIsRunning = false;
        private double mdblMinTemperature = 0;
        private double mdblMinHumidity = 0;
        private double mdblAlertTemperature = 0;
        private string mstrStringDevice = String.Empty;
        private string mstrStringService = String.Empty;
        private int mintMsgSent = 0;
        private int mintMsgReceived = 0;
        private int mintAlertSent = 0;
        private CancellationTokenSource mobjCancellationToken;
        private DeviceClient mobjDevice;
        #endregion

        #region Metodos para o dispositivo
        /// <summary>
        /// Método para ser chamado diretamente
        /// </summary>
        /// <param name="methodRequest">Dados da requisição</param>
        /// <param name="userContext">Dados do contexto do usuario</param>
        /// <returns></returns>
        private Task<MethodResponse> SetAlertMinimum(MethodRequest methodRequest, object userContext)
        {
            var data = Encoding.UTF8.GetString(methodRequest.Data);

            // Verifica se o dado que chegou é valido (inteiro)
            if (int.TryParse(data, out int dblAlertTemperature))
            {
                mdblAlertTemperature = dblAlertTemperature;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Mudança no parâmetro Alerta de temperatura para {mdblAlertTemperature}");
                Console.ResetColor();
                mintMsgReceived++;

                // Informa com HTTP 200 que o método foi executado
                string result = $"{{\"result\":\"Método: {methodRequest.Name}\"}}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 200));
            }
            else
            {
                // Informa com HTTP 400 que houve um erro na execução
                string result = "{\"result\":\"Parametro invalido\"}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 400));
            }
        }

        /// <summary>
        /// Envia as mensagens para o Azure IoT Hub
        /// </summary>
        /// <param name="cancellationToekn">Token para monitorar o cancelamento</param>
        private async void SendMessagesProcessAsync(CancellationToken cancellationToekn)
        {
            // Cria o dispostivo
            bool blnAlert;

            //Obtem os dados 
            double minTemperature = mdblMinTemperature;
            double minHumidity = mdblMinHumidity;
            var rand = new Random();

            // Apenas montar o status
            Console.WriteLine("Gerando informações...");

            while (!cancellationToekn.IsCancellationRequested)
            {
                // Organiza os dados
                blnAlert = false;
                double currentTemperature = minTemperature + rand.NextDouble() * 15;
                double currentHumidity = minHumidity + rand.NextDouble() * 20;

                // Cria a mensagem JSON
                string messageBody = JsonSerializer.Serialize(
                    new
                    {
                        temperature = currentTemperature,
                        humidity = currentHumidity,
                    });
                using var message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(messageBody))
                {
                    ContentType = "application/json",
                    ContentEncoding = "utf-8",
                };

                // Adiciona uma propriedade para caso de acima da temperatura
                // o Azure Hub IOT pode usar este campo para filtrar e rotear a mensagem.
                if(currentTemperature > mdblAlertTemperature)
                {
                    blnAlert = true;
                    message.Properties.Add("temperatureAlert", "true");
                    mintAlertSent++;
                } 
                else
                {
                    blnAlert = false;
                    message.Properties.Add("temperatureAlert", "false");
                }
                

                // Envia a mensagem para o Azure IOT Hub
                await mobjDevice.SendEventAsync(message);

                // Atualiza elementos da Interface
                mintMsgSent++;
                txtMsgSent.Text = mintMsgSent.ToString();
                txtAlertSent.Text = mintAlertSent.ToString();
                txtMsgReceived.Text = mintMsgReceived.ToString();
                if(blnAlert)
                {
                    Console.ForegroundColor = ConsoleColor.Red;                    
                }
                Console.WriteLine(messageBody);
                Console.ResetColor();


                await Task.Delay(1000);
            }

            Console.WriteLine("Fim da geração.");
        }
        #endregion

        #region Tratamento de Eventos do Classe Windows Forms
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();

            //Cria a tela de output para monitorar
            AllocConsole();
        }

        /// <summary>
        /// Trata o evento do click do botão execução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cmdActivate_Click(object sender, EventArgs e)
        {
            if(mblnIsRunning) // Cancela a execução do dispositivo
            {
                // Cancela a execução
                mobjCancellationToken.Cancel();

                // Volta os parametros para o comportamento padrão
                cmdActivate.Text = "Ativar";
                lblStatus.Text = "Idle";
                mblnIsRunning = false;
                txtAlertTemperature.ReadOnly = false;
                txtDeviceName.ReadOnly = false;
                txtMinHumi.ReadOnly = false;
                txtMinTemperature.ReadOnly = false;
                txtStringDevice.ReadOnly = false;
                txtStringService.ReadOnly = false;

            }
            else // Inicia a execução do dispositivo
            {
                //Preenche os parametros
                mintMsgReceived = 0;
                mintMsgSent = 0;
                mintAlertSent = 0;
                mstrStringService = txtStringService.Text;
                mstrStringDevice = txtStringDevice.Text;
                mdblAlertTemperature = double.Parse(txtAlertTemperature.Text);
                mdblMinHumidity = double.Parse(txtMinHumi.Text);
                mdblMinTemperature = double.Parse(txtMinTemperature.Text);

                //Cria o dispositivo que será usado nas funções 
                mobjDevice = DeviceClient.CreateFromConnectionString(mstrStringService);

                // Registra o método de CallBack
                // Create a handler for the direct method call
                await mobjDevice.SetMethodHandlerAsync("SetAlertMinimum", SetAlertMinimum, null);

                // Chama a função
                mobjCancellationToken = new CancellationTokenSource();
                CancellationToken objCt = mobjCancellationToken.Token;
                SendMessagesProcessAsync(objCt);

                // Volta os parametros para o comportamento padrão
                cmdActivate.Text = "Cancelar";
                lblStatus.Text = "Executando...";
                mblnIsRunning = true;
                txtAlertTemperature.ReadOnly = true;
                txtDeviceName.ReadOnly = true;
                txtMinHumi.ReadOnly = true;
                txtMinTemperature.ReadOnly = true;
                txtStringDevice.ReadOnly = true;
                txtStringService.ReadOnly = true;
            }
        }

        /// <summary>
        /// Caso o usuario feche a janela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_FormClosing(object sender, EventArgs e)
        {
            // Fecha a tela do console
            FreeConsole();
        }

        #endregion
    }
}
