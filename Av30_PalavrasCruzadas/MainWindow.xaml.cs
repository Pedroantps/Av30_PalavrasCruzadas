using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Av30_PalavrasCruzadas
{
    public partial class MainWindow : Window
    {
        string palavra1 = "";
        string palavra2 = "";
        string palavra3 = "";
        string palavra4 = "";
        string palavra5 = "";
        string palavra6 = "";
        string palavra7 = "";
        string palavra8 = "";
        string palavra9 = "";
        string palavra10 = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void click1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(
            "Ocorrências detectáveis ou perceptíveis, com impacto e importância, que normalmente são registradas por um serviço automático ou por uma ferramenta de monitoração.",
            "Dica 1",
            MessageBoxButton.OK,
            MessageBoxImage.Information);

        }

        private void click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Fase de um sistema de informação e consiste no processo de aplicar mudanças aos sistemas durante a sua vida útil, de acordo com as necessidades da organização e/ou dos utilizadores.",
            "Dica 2",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Evento que não faz parte do funcionamento padrão de um serviçode TI e que causa (ou pode causar) uma interrupção do serviço ou redução de seu nível de desempenho.",
            "Dica 3",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "'O servidor da empresa informou ao sistema de suporte que seu espaço de armazenamento está quase cheio'. Isso se refere a qual tipo de evento?.",
            "Dica 4",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "'O espaço de armazenamento está cheio, o servidor não conseguemais armazenar nenhum dado.' Isso se refere a qual tipo de evento?",
            "Dica 5",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "'Confirmar a identidade da pessoa ou entidade que presta informação.' Esse trecho corresponde a que tipo segurança da informação relacionada a implantação de sistemas?",
            "Dica 6",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Quando criamos testes em que o foco seria testar pequenas partes do sistema, mais especificamente os métodos que ali foram desenvolvidos. Teste de _______",
            "Dica 7",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Leva-se o software ao seu limite de potência e funcionamento, para mais ou para menos, de modo a avaliar em qual ponto ele deixa de funcionar adequadamente. Estamos falando do teste de ________.",
            "Dica 8",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Esse teste é feito para avaliar os limites de uso do software, o quanto ele suporta em volume de informações, tráfego etc. sem que apresente erros. Teste de ________.",
            "Dica 9",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "O foco é reduzir as oportunidades para falha do sistema ou, ainda, aumentar a sua vida útil. Manutenção ________.",
            "Dica 10",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }
        private void logicaEventos()
        {

            if (txtPreventiva5_Evento1.Text.ToUpper() == "E" && txtEventos2.Text.ToUpper() == "V" && txtEventos3.Text.ToUpper() == "E" && txtEventos4_manutencao3.Text.ToUpper() == "N" && txtEventos5.Text.ToUpper() == "T" && txtEventos6.Text.ToUpper() == "O" && txtEventos7.Text.ToUpper() == "S")
            {
                if (palavra1 == "EVENTOS")
                {
                    txtPreventiva5_Evento1.Text = "E";
                    txtEventos2.Text = "V";
                    txtEventos3.Text = "E";
                    txtEventos4_manutencao3.Text = "N";
                    txtEventos5.Text = "T";
                    txtEventos6.Text = "O";
                    txtEventos7.Text = "S";
                    txtPreventiva5_Evento1.Background = Brushes.Green;
                    txtEventos2.Background = Brushes.Green;
                    txtEventos3.Background = Brushes.Green;
                    txtEventos4_manutencao3.Background = Brushes.Green;
                    txtEventos5.Background = Brushes.Green;
                    txtEventos6.Background = Brushes.Green;
                    txtEventos7.Background = Brushes.Green;
                    txtPreventiva5_Evento1.IsEnabled = false;
                    txtEventos2.IsEnabled = false;
                    txtEventos3.IsEnabled = false;
                    txtEventos4_manutencao3.IsEnabled = false;
                    txtEventos5.IsEnabled = false;
                    txtEventos6.IsEnabled = false;
                    txtEventos7.IsEnabled = false;
                }
            }
        }


        private void logicaManutencao()
        {
            if (txtManutencao1.Text.ToUpper() == "M" && txtManutencao2.Text.ToUpper() == "A" && txtEventos4_manutencao3.Text.ToUpper() == "N" && txtManutencao4.Text.ToUpper() == "U" && txtManutencao5.Text.ToUpper() == "T" && txtManutencao6_Excecao1.Text.ToUpper() == "E" && txtManutencao7.Text.ToUpper() == "N" && txtManutencao8.Text.ToUpper() == "Ç" && txtManutencao9.Text.ToUpper() == "A" && txtManutencao10_Avisos5.Text.ToUpper() == "O")
            {
                if (palavra2 == "MANUTENÇAO")
                {
                    txtManutencao1.Text = "M";
                    txtManutencao2.Text = "A";
                    txtEventos4_manutencao3.Text = "N";
                    txtManutencao4.Text = "U";
                    txtManutencao5.Text = "T";
                    txtManutencao6_Excecao1.Text = "E";
                    txtManutencao7.Text = "N";
                    txtManutencao8.Text = "Ç";
                    txtManutencao9.Text = "A";
                    txtManutencao10_Avisos5.Text = "O";
                    txtManutencao1.Background = Brushes.Green;
                    txtManutencao2.Background = Brushes.Green;
                    txtEventos4_manutencao3.Background = Brushes.Green;
                    txtManutencao4.Background = Brushes.Green;
                    txtManutencao5.Background = Brushes.Green;
                    txtManutencao6_Excecao1.Background = Brushes.Green;
                    txtManutencao7.Background = Brushes.Green;
                    txtManutencao8.Background = Brushes.Green;
                    txtManutencao9.Background = Brushes.Green;
                    txtManutencao10_Avisos5.Background = Brushes.Green;
                    txtManutencao1.IsEnabled = false;
                    txtManutencao2.IsEnabled = false;
                    txtEventos4_manutencao3.IsEnabled = false;
                    txtManutencao4.IsEnabled = false;
                    txtManutencao5.IsEnabled = false;
                    txtManutencao6_Excecao1.IsEnabled = false;
                    txtManutencao7.IsEnabled = false;
                    txtManutencao8.IsEnabled = false;
                    txtManutencao9.IsEnabled = false;
                    txtManutencao10_Avisos5.IsEnabled = false;
                }
            }

        }

        private void LogicaIncidente()
        {
            if (txtAvisos3_Incidente1.Text.ToUpper() == "I" && txtIncidente2.Text.ToUpper() == "N" && txtIncidente3_Carga1.Text.ToUpper() == "C" && txtIncidente4.Text.ToUpper() == "I" && txtIncidente5.Text.ToUpper() == "D" && txtIncidente6_Estresse1.Text.ToUpper() == "E" && txtIncidente7.Text.ToUpper() == "N" && txtIncidente8_Autenticidade3.Text.ToUpper() == "T" && txtIncidente9.Text.ToUpper() == "E")
            {
                if (palavra3 == "INCIDENTE")
                {
                    txtAvisos3_Incidente1.Text = "I";
                    txtIncidente2.Text = "N";
                    txtIncidente3_Carga1.Text = "C";
                    txtIncidente4.Text = "I";
                    txtIncidente5.Text = "D";
                    txtIncidente6_Estresse1.Text = "E";
                    txtIncidente7.Text = "N";
                    txtIncidente8_Autenticidade3.Text = "T";
                    txtIncidente9.Text = "E";
                    txtAvisos3_Incidente1.Background = Brushes.Green;
                    txtIncidente2.Background = Brushes.Green;
                    txtIncidente3_Carga1.Background = Brushes.Green;
                    txtIncidente4.Background = Brushes.Green;
                    txtIncidente5.Background = Brushes.Green;
                    txtIncidente6_Estresse1.Background = Brushes.Green;
                    txtIncidente7.Background = Brushes.Green;
                    txtIncidente8_Autenticidade3.Background = Brushes.Green;
                    txtIncidente9.Background = Brushes.Green;
                    txtAvisos3_Incidente1.IsEnabled = false;
                    txtIncidente2.IsEnabled = false;
                    txtIncidente3_Carga1.IsEnabled = false;
                    txtIncidente4.IsEnabled = false;
                    txtIncidente5.IsEnabled = false;
                    txtIncidente6_Estresse1.IsEnabled = false;
                    txtIncidente7.IsEnabled = false;
                    txtIncidente8_Autenticidade3.IsEnabled = false;
                    txtIncidente9.IsEnabled = false;
                }
            }
        }

        private void LogicaAvisos()
        {
            if (txtAvisos1.Text.ToUpper() == "A" && txtAvisos2.Text.ToUpper() == "V" && txtAvisos3_Incidente1.Text.ToUpper() == "I" && txtAvisos4.Text.ToUpper() == "S" && txtManutencao10_Avisos5.Text.ToUpper() == "O" && txtAvisos6.Text.ToUpper() == "S")
            {
                if (palavra4 == "AVISOS")
                {
                    txtAvisos1.Text = "A";
                    txtAvisos2.Text = "V";
                    txtAvisos3_Incidente1.Text = "I";
                    txtAvisos4.Text = "S";
                    txtManutencao10_Avisos5.Text = "O";
                    txtAvisos6.Text = "S";
                    txtAvisos1.Background = Brushes.Green;
                    txtAvisos2.Background = Brushes.Green;
                    txtAvisos3_Incidente1.Background = Brushes.Green;
                    txtAvisos4.Background = Brushes.Green;
                    txtManutencao10_Avisos5.Background = Brushes.Green;
                    txtAvisos6.Background = Brushes.Green;
                    txtAvisos1.IsEnabled = false;
                    txtAvisos2.IsEnabled = false;
                    txtAvisos3_Incidente1.IsEnabled = false;
                    txtAvisos4.IsEnabled = false;
                    txtManutencao10_Avisos5.IsEnabled = false;
                    txtAvisos6.IsEnabled = false;
                }
            }
        }

        private void LogicaExcecao()
        {
            if (txtManutencao6_Excecao1.Text.ToUpper() == "E" && txtExcecao2.Text.ToUpper() == "X" && txtExcecao3.Text.ToUpper() == "C" && txtExcecao4.Text.ToUpper() == "E" && txtExcecao5.Text.ToUpper() == "Ç" && txtExcecao6.Text.ToUpper() == "A" && txtExcecao7.Text.ToUpper() == "O")
            {
                if (palavra5 == "EXCEÇAO")
                {
                    txtManutencao6_Excecao1.Text = "E";
                    txtExcecao2.Text = "X";
                    txtExcecao3.Text = "C";
                    txtExcecao4.Text = "E";
                    txtExcecao5.Text = "Ç";
                    txtExcecao6.Text = "A";
                    txtExcecao7.Text = "O";
                    txtManutencao6_Excecao1.Background = Brushes.Green;
                    txtExcecao2.Background = Brushes.Green;
                    txtExcecao3.Background = Brushes.Green;
                    txtExcecao4.Background = Brushes.Green;
                    txtExcecao5.Background = Brushes.Green;
                    txtExcecao6.Background = Brushes.Green;
                    txtExcecao7.Background = Brushes.Green;
                    txtManutencao6_Excecao1.IsEnabled = false;
                    txtExcecao2.IsEnabled = false;
                    txtExcecao3.IsEnabled = false;
                    txtExcecao4.IsEnabled = false;
                    txtExcecao5.IsEnabled = false;
                    txtExcecao6.IsEnabled = false;
                    txtExcecao7.IsEnabled = false;
                }
            }
        }

        private void LogicaAutenticidade()
        {
            if (txtAutenticidade1.Text.ToUpper() == "A" && txtAutenticidade2.Text.ToUpper() == "U" && txtIncidente8_Autenticidade3.Text.ToUpper() == "T" && txtAutenticidade4.Text.ToUpper() == "E" && txtAutenticidade5.Text.ToUpper() == "N" && txtAutenticidade6.Text.ToUpper() == "T" && txtAutenticidade7.Text.ToUpper() == "I" && txtAutenticidade8.Text.ToUpper() == "C" && txtAutenticidade9.Text.ToUpper() == "I" && txtAutenticidade10.Text.ToUpper() == "D" && txtAutenticidade11.Text.ToUpper() == "A" && txtAutenticidade12_Unidade6.Text.ToUpper() == "D" && txtAutenticidade13.Text.ToUpper() == "E")
            {
                if (palavra6 == "AUTENTICIDADE")
                {
                    txtAutenticidade1.Text = "A";
                    txtAutenticidade2.Text = "U";
                    txtIncidente8_Autenticidade3.Text = "T";
                    txtAutenticidade4.Text = "E";
                    txtAutenticidade5.Text = "N";
                    txtAutenticidade6.Text = "T";
                    txtAutenticidade7.Text = "I";
                    txtAutenticidade8.Text = "C";
                    txtAutenticidade9.Text = "I";
                    txtAutenticidade10.Text = "D";
                    txtAutenticidade11.Text = "A";
                    txtAutenticidade12_Unidade6.Text = "D";
                    txtAutenticidade13.Text = "E";
                    txtAutenticidade1.Background = Brushes.Green;
                    txtAutenticidade2.Background = Brushes.Green;
                    txtIncidente8_Autenticidade3.Background = Brushes.Green;
                    txtAutenticidade4.Background = Brushes.Green;
                    txtAutenticidade5.Background = Brushes.Green;
                    txtAutenticidade6.Background = Brushes.Green;
                    txtAutenticidade7.Background = Brushes.Green;
                    txtAutenticidade8.Background = Brushes.Green;
                    txtAutenticidade9.Background = Brushes.Green;
                    txtAutenticidade10.Background = Brushes.Green;
                    txtAutenticidade11.Background = Brushes.Green;
                    txtAutenticidade12_Unidade6.Background = Brushes.Green;
                    txtAutenticidade13.Background = Brushes.Green;
                    txtAutenticidade1.IsEnabled = false;
                    txtAutenticidade2.IsEnabled = false;
                    txtIncidente8_Autenticidade3.IsEnabled = false;
                    txtAutenticidade4.IsEnabled = false;
                    txtAutenticidade5.IsEnabled = false;
                    txtAutenticidade6.IsEnabled = false;
                    txtAutenticidade7.IsEnabled = false;
                    txtAutenticidade8.IsEnabled = false;
                    txtAutenticidade9.IsEnabled = false;
                    txtAutenticidade10.IsEnabled = false;
                    txtAutenticidade11.IsEnabled = false;
                    txtAutenticidade12_Unidade6.IsEnabled = false;
                    txtAutenticidade13.IsEnabled = false;
                }
            }
        }

        private void LogicaUnidade()
        {
            if (txtUnidade1.Text.ToUpper() == "U" && txtUnidade2.Text.ToUpper() == "N" && txtUnidade3.Text.ToUpper() == "I" && txtUnidade4.Text.ToUpper() == "D" && txtUnidade5.Text.ToUpper() == "A" && txtAutenticidade12_Unidade6.Text.ToUpper() == "D" && txtUnidade7.Text.ToUpper() == "E")
            {
                if (palavra7 == "UNIDADE")
                {
                    txtUnidade1.Text = "U";
                    txtUnidade2.Text = "N";
                    txtUnidade3.Text = "I";
                    txtUnidade4.Text = "D";
                    txtUnidade5.Text = "A";
                    txtAutenticidade12_Unidade6.Text = "D";
                    txtUnidade7.Text = "E";
                    txtUnidade1.Background = Brushes.Green;
                    txtUnidade2.Background = Brushes.Green;
                    txtUnidade3.Background = Brushes.Green;
                    txtUnidade4.Background = Brushes.Green;
                    txtUnidade5.Background = Brushes.Green;
                    txtAutenticidade12_Unidade6.Background = Brushes.Green;
                    txtUnidade7.Background = Brushes.Green;
                    txtUnidade1.IsEnabled = false;
                    txtUnidade2.IsEnabled = false;
                    txtUnidade3.IsEnabled = false;
                    txtUnidade4.IsEnabled = false;
                    txtUnidade5.IsEnabled = false;
                    txtAutenticidade12_Unidade6.IsEnabled = false;
                    txtUnidade7.IsEnabled = false;
                }
            }
        }

        private void LogicaEstresse()
        {
            if (txtIncidente6_Estresse1.Text.ToUpper() == "E" && txtEstresse2.Text.ToUpper() == "S" && txtEstresse3.Text.ToUpper() == "T" && txtEstresse4.Text.ToUpper() == "R" && txtEstresse5.Text.ToUpper() == "E" && txtEstresse6.Text.ToUpper() == "S" && txtEstresse7.Text.ToUpper() == "S" && txtEstresse8.Text.ToUpper() == "E")
            {
                if (palavra8 == "ESTRESSE")
                {
                    txtManutencao6_Excecao1.Text = "E";
                    txtEstresse2.Text = "S";
                    txtEstresse3.Text = "T";
                    txtEstresse4.Text = "R";
                    txtEstresse5.Text = "E";
                    txtEstresse6.Text = "S";
                    txtEstresse7.Text = "S";
                    txtEstresse8.Text = "E";
                    txtIncidente6_Estresse1.Background = Brushes.Green;
                    txtEstresse2.Background = Brushes.Green;
                    txtEstresse3.Background = Brushes.Green;
                    txtEstresse4.Background = Brushes.Green;
                    txtEstresse5.Background = Brushes.Green;
                    txtEstresse6.Background = Brushes.Green;
                    txtEstresse7.Background = Brushes.Green;
                    txtEstresse8.Background = Brushes.Green;
                    txtIncidente6_Estresse1.IsEnabled = false;
                    txtEstresse2.IsEnabled = false;
                    txtEstresse3.IsEnabled = false;
                    txtEstresse4.IsEnabled = false;
                    txtEstresse5.IsEnabled = false;
                    txtEstresse6.IsEnabled = false;
                    txtEstresse7.IsEnabled = false;
                    txtEstresse8.IsEnabled = false;
                }
            }
        }
        private void LogicaCarga()
        {
            if (txtIncidente3_Carga1.Text.ToUpper() == "C" && txtCarga2.Text.ToUpper() == "A" && txtCarga3.Text.ToUpper() == "R" && txtCarga4.Text.ToUpper() == "G" && txtCarga5.Text.ToUpper() == "A")
            {
                if (palavra9 == "CARGA")
                {
                    txtIncidente3_Carga1.Text = "C";
                    txtCarga2.Text = "A";
                    txtCarga3.Text = "R";
                    txtCarga4.Text = "G";
                    txtCarga5.Text = "A";
                    txtIncidente3_Carga1.Background = Brushes.Green;
                    txtCarga2.Background = Brushes.Green;
                    txtCarga3.Background = Brushes.Green;
                    txtCarga4.Background = Brushes.Green;
                    txtCarga5.Background = Brushes.Green;
                    txtIncidente6_Estresse1.IsEnabled = false;
                    txtCarga2.IsEnabled = false;
                    txtCarga3.IsEnabled = false;
                    txtCarga4.IsEnabled = false;
                    txtCarga5.IsEnabled = false;
                }
            }
        }

        private void LogicaPreventiva()
        {
            if (txtPreventiva1.Text.ToUpper() == "P" && txtPreventiva2.Text.ToUpper() == "R" && txtPreventiva3.Text.ToUpper() == "E" && txtPreventiva4.Text.ToUpper() == "V" && txtPreventiva5_Evento1.Text.ToUpper() == "E" && txtPreventiva6.Text.ToUpper() == "N" && txtPreventiva7.Text.ToUpper() == "T" && txtPreventiva8.Text.ToUpper() == "I" && txtPreventiva9.Text.ToUpper() == "V" && txtPreventiva10.Text.ToUpper() == "A")
            {
                if (palavra10 == "PREVENTIVA")
                {
                    txtPreventiva1.Text = "P";
                    txtPreventiva2.Text = "R";
                    txtPreventiva3.Text = "E";
                    txtPreventiva4.Text = "V";
                    txtPreventiva5_Evento1.Text = "E";
                    txtPreventiva1.Text = "N";
                    txtPreventiva7.Text = "T";
                    txtPreventiva8.Text = "I";
                    txtPreventiva9.Text = "V";
                    txtPreventiva10.Text = "A";
                    txtPreventiva1.Background = Brushes.Green;
                    txtPreventiva2.Background = Brushes.Green;
                    txtPreventiva3.Background = Brushes.Green;
                    txtPreventiva4.Background = Brushes.Green;
                    txtPreventiva5_Evento1.Background = Brushes.Green;
                    txtPreventiva6.Background = Brushes.Green;
                    txtPreventiva7.Background = Brushes.Green;
                    txtPreventiva8.Background = Brushes.Green;
                    txtPreventiva9.Background = Brushes.Green;
                    txtPreventiva10.Background = Brushes.Green;
                    txtPreventiva1.IsEnabled = false;
                    txtPreventiva2.IsEnabled = false;
                    txtPreventiva3.IsEnabled = false;
                    txtPreventiva4.IsEnabled = false;
                    txtPreventiva5_Evento1.IsEnabled = false;
                    txtPreventiva6.IsEnabled = false;
                    txtPreventiva7.IsEnabled = false;
                    txtPreventiva8.IsEnabled = false;
                    txtPreventiva9.IsEnabled = false;
                    txtPreventiva10.IsEnabled = false;
                }
            }
        }
        private void Vitoria()
        {
            if (palavra1 == "EVENTOS" && palavra2 == "MANUTENÇAO" && palavra3 == "INCIDENTE" && palavra4 == "AVISOS" && palavra5 == "EXCEÇAO" && palavra6 == "AUTENTICIDADE" && palavra7 == "UNIDADE" && palavra8 == "ESTRESSE" && palavra9 == "CARGA" && palavra10 == "PREVENTIVA")
            {
                txtVitoria.Visibility = Visibility.Visible;
            }
        }
        private void verifica(object sender, KeyEventArgs e)
        {
            palavra1 = txtPreventiva5_Evento1.Text + txtEventos2.Text + txtEventos3.Text + txtEventos4_manutencao3.Text + txtEventos5.Text + txtEventos6.Text + txtEventos7.Text;
            palavra1 = palavra1.ToUpper();
            palavra2 = txtManutencao1.Text + txtManutencao2.Text + txtEventos4_manutencao3.Text + txtManutencao4.Text + txtManutencao5.Text + txtManutencao6_Excecao1.Text + txtManutencao7.Text + txtManutencao8.Text + txtManutencao9.Text + txtManutencao10_Avisos5.Text;
            palavra2 = palavra2.ToUpper();
            palavra3 = txtAvisos3_Incidente1.Text + txtIncidente2.Text + txtIncidente3_Carga1.Text + txtIncidente4.Text + txtIncidente5.Text + txtIncidente6_Estresse1.Text + txtIncidente7.Text + txtIncidente8_Autenticidade3.Text + txtIncidente9.Text;
            palavra3 = palavra3.ToUpper();
            palavra4 = txtAvisos1.Text + txtAvisos2.Text + txtAvisos3_Incidente1.Text + txtAvisos4.Text + txtManutencao10_Avisos5.Text + txtAvisos6.Text;
            palavra4 = palavra4.ToUpper();
            palavra5 = txtManutencao6_Excecao1.Text + txtExcecao2.Text + txtExcecao3.Text + txtExcecao4.Text + txtExcecao5.Text + txtExcecao6.Text + txtExcecao7.Text;
            palavra5 = palavra5.ToUpper();
            palavra6 = txtAutenticidade1.Text + txtAutenticidade2.Text + txtIncidente8_Autenticidade3.Text + txtAutenticidade4.Text + txtAutenticidade5.Text + txtAutenticidade6.Text + txtAutenticidade7.Text + txtAutenticidade8.Text + txtAutenticidade9.Text + txtAutenticidade10.Text + txtAutenticidade11.Text + txtAutenticidade12_Unidade6.Text + txtAutenticidade13.Text;
            palavra6 = palavra6.ToUpper();
            palavra7 = txtUnidade1.Text + txtUnidade2.Text + txtUnidade3.Text + txtUnidade4.Text + txtUnidade5.Text + txtAutenticidade12_Unidade6.Text + txtUnidade7.Text;
            palavra7 = palavra7.ToUpper();
            palavra8 = txtIncidente6_Estresse1.Text + txtEstresse2.Text + txtEstresse3.Text + txtEstresse4.Text + txtEstresse5.Text + txtEstresse6.Text + txtEstresse7.Text + txtEstresse8.Text;
            palavra8 = palavra8.ToUpper();
            palavra9 = txtIncidente3_Carga1.Text + txtCarga2.Text + txtCarga3.Text + txtCarga4.Text + txtCarga5.Text;
            palavra9 = palavra9.ToUpper();
            palavra10 = txtPreventiva1.Text + txtPreventiva2.Text + txtPreventiva3.Text + txtPreventiva4.Text + txtPreventiva5_Evento1.Text + txtPreventiva6.Text + txtPreventiva7.Text + txtPreventiva8.Text + txtPreventiva9.Text + txtPreventiva10.Text;
            palavra10 = palavra10.ToUpper();
            logicaEventos();
            logicaManutencao();
            LogicaIncidente();
            LogicaAvisos();
            LogicaExcecao();
            LogicaAutenticidade();
            LogicaUnidade();
            LogicaEstresse();
            LogicaCarga();
            LogicaPreventiva();
            Vitoria();
        }
    }
}
