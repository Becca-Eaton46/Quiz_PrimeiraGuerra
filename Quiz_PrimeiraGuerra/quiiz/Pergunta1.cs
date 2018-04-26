using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiiz
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false; // desativa o botão passar
        }



        private void Pergunta2()
        {
            label1.Text = "QUESTÃO 2";
            label2.Text = "Quem eram os países envolvidos na Tríplice aliança?";
            radioButton1.Text = "a) França, Russia e Inglaterra";
            radioButton2.Text = "b) Inglaterra, Russia e Império Austro-Húngaro";
            radioButton3.Text = "c) Alemanha, o Império Austro-Húngaro e a Itália";
            radioButton4.Text = "d)Russia, Alemanha e Itália";
            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta3()
        {
            label1.Text = "QUESTÃO 3";

            label2.Text = "O período da belle époque foi um dos momentos mais feliz" +
                " e prósperos da história da Europa, também foi um dos " +
                "principais motivos para o inicio da 1° Guerra mundial. O " +
                "que foi a belle époque?";

            radioButton1.Text = "a) Representou uma verdadeira renovação da linguagem," +
                " na busca de experimentação, na liberdade criadora e na ruptura com o passado." +
                " O evento marcou época ao apresentar novas ideias e conceitos artísticos.";

            radioButton2.Text = "b) Uma manifestação do realismo mas as diferenças são bem visíveis." +
                " Tenta explicar que o homem é modificado pelo ambiente em que vive e que a natureza influi na razão.";

            radioButton3.Text = "c)Foi um período de grandes descobertas cientificas e de grande" +
                " euforia com a nova tecnologia que, eles criam, que resolveria todos os seus problemas." +
                " As novas tecnologias trouxeram por exemplo os carros, fotografias porém também" +
                " causaram conflitos que deixaram o país vulnerável ao ataque de outros e dai surgiu a" +
                " frase: as luzes se apagaram, a tristeza caiu sobre nós";

            radioButton4.Text = "Foi a época em que as máquinas foram inventadas, " +
                "com o propósito de poupar o tempo do trabalho humano. Uma delas era a máquina a vapor.";

            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta4()
        {
            label1.Text = "QUESTÃO 4";
            label2.Text = "Naquela época qual era o país com o maior poder político e econômico na Europa?";
            radioButton1.Text = "a) França";
            radioButton2.Text = "b) Inglaterra";
            radioButton3.Text = "c) Rússia";
            radioButton4.Text = "d) Alemanha";
            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta5()
        {
            label1.Text = "QUESTÃO 5";
            label2.Text = "Como a Rússia entrou na guerra? ";

            radioButton1.Text = "a)  Nos três primeiros anos da guerra, A Rússia permaneceu neutro." +
                " Porém, em 5 de abril de 1917, um submarino alemão atacou um navio Russo carregado de café." +
                " Em 20 de maio, outro navio russo, agora o Tijuca, navegando em águas francesas," +
                " foi torpedeado por um submarino alemão. " +
                "Estes fatos foram o estopim para a entrada da Rússia no conflito.";

            radioButton2.Text = "b) A rússia e a Alemanha competiam industrialmente e comercialmente." +
                " A Alemanha tornou-se uma grande potência industrial. Fortalecida," +
                " a Alemanha passou a pressionar para que houvesse uma nova repartição" +
                " do mundo colonial. A Rússia, por sua, vez, mostrava disposição em" +
                " manter suas conquistas a qualquer custo.";

            radioButton3.Text = "c)No início da Primeira Guerra Mundial," +
                " a Rússia abandonou a Tríplice Aliança e se recusou a participar do conflito." +
                " Contudo, em função das promessas territoriais que recebeu, " +
                "a Rússia entrou no conflito ao lado da Tríplice Entente.";

            radioButton4.Text = "d)A Rússia era aliada da Sérvia que," +
                " devido ao assassinato do arquiduque Francisco Ferdinando," +
                " teve guerra declarada sobre si por parte do império austro-húngaro. " +
                "Por conta disso, a Sérvia também declarou guerra ao império e" +
                " assim também fez a Rússia, já que era sua aliada.";

            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta6()
        {
            label1.Text = "QUESTÃO 6";
            label2.Text = " quais países faziam parte da Tríplice Entente?";
            radioButton1.Text = "a) Russia, Inglaterra e França";
            radioButton2.Text = "b) Russia, Alemanha e Itália";
            radioButton3.Text = "c) EUA, Inglaterra, e França";
            radioButton4.Text = "d)Canadá, Brasil, EUA";
            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta7()
        {
            label1.Text = "QUESTÃO 7";
            label2.Text = "Qual das alternativas está incorreta em relação as consequências da Primeira Grande Guerra?";
            radioButton1.Text = "a) O império turco após 200 anos de decadência se dividiu.";
            radioButton2.Text = "b) Surgimento de alguns países (Iugoslávia) e desaparecimento de outros.";
            radioButton3.Text = "c) O império Austro-Húngaro se fortaleceu";
            radioButton4.Text = "d) Os EUA tornaram-se o país mais rico do mundo.";
            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta8()
        {
            label1.Text = "QUESTÃO 8";
            label2.Text = "Qual desses itens não foi inventado por causa da primeira guerra mundial?";
            radioButton1.Text = "a)  Drones";
            radioButton2.Text = "b) Penicilina para feridas";
            radioButton3.Text = "c) Absorventes higiênicos";
            radioButton4.Text = "d) Zeppelin";
            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta9()
        {
            label1.Text = "QUESTÃO 9";
            label2.Text = "Em quais anos se deram (respectivamente) o inicio e o fim da Primeira Grande Guerra?";
            radioButton1.Text = "a) 1914 - 1918";
            radioButton2.Text = "b) 1904 - 1914";
            radioButton3.Text = "c) 1914 - 1921";
            radioButton4.Text = "d) 1904 - 1945";
            resposta.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void Pergunta10()
        {
            label1.Text = "QUESTÃO 10";
            label2.Text = "O que é correto afirmar sobre o tratado de Versalhes?";
            radioButton1.Text = "a) Foi um tratado que dividia o território da Alemanha";
            radioButton2.Text = "b) Foi um acordo de paz entre os países durante a Primeira Grande guerra.";
            radioButton3.Text = "c) Foi uma reunião que ocorreu na França, onde eles decidiram atacar a Rússia.";
            radioButton4.Text = "d) Foi um acordo de paz selado entre as potências vencedoras da Primeira Guerra " +
                "Mundial e a Alemanha derrotada.";
            resposta.Text = "";
            button3.Text = "Finalizar";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            radioButton1.Checked = false; // limpar o radiobutton
            radioButton2.Checked = false; // limpar o radiobutton
            radioButton3.Checked = false; // limpar o radiobutton
            radioButton4.Checked = false; // limpar o radiobutton


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Verificar1(true))
            {
                button3.Enabled = true;
            }

            if (Verificar2(true))
            {
                button3.Enabled = true;
            }

            if (Verificar3(true))
            {
                button3.Enabled = true;
            }

            if (Verificar4(true))
            {
                button3.Enabled = true;
            }

            if (Verificar5(true))
            {
                button3.Enabled = true;
            }

            if (Verificar6(true))
            {
                button3.Enabled = true;
            }

            if (Verificar7(true))
            {
                button3.Enabled = true;
            }

            if (Verificar8(true))
            {
                button3.Enabled = true;
            }

            if (Verificar9(true))
            {
                button3.Enabled = true;
            }

            if (Verificar10(true))
            {
                button3.Enabled = true;
            }
        }

            private Boolean Verificar1(bool valor)
            {
                if(radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }


        

            private Boolean Verificar2(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta correta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }

            private Boolean Verificar3(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }

            private Boolean Verificar4(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }

            private Boolean Verificar5(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }

            private Boolean Verificar6(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }

            private Boolean Verificar7(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

            return true;
            }

            private Boolean Verificar8(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;
            }

            private Boolean Verificar9(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

            return true;
            }

            private Boolean Verificar10(bool valor)
            {
                if (radioButton1.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton2.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton3.Checked == true)
                {
                    resposta.Text = "Resposta Incorreta";
                }

                if (radioButton4.Checked == true)
                {
                    resposta.Text = "Resposta Correta";
                }

                button2.Enabled = false;
                button3.Enabled = true;

                return true;



             }





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true; // desativa o botão pular
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true; // desativa o botão pular
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true; // desativa o botão pular
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Questão 1")
            {
                if (resposta.Text == "")
                {
                    Pergunta2();
                }

            }
            if (label1.Text == "Questão 2")
            {
                if (resposta.Text == "")
                {
                    Pergunta3();
                }

            }
            if (label1.Text == "Questão 3")
            {
                if (resposta.Text == "")
                {
                    Pergunta4();
                }

            }
            if (label1.Text == "Questão 4")
            {
                if (resposta.Text == "")
                {
                    Pergunta5();
                }

            }
            if (label1.Text == "Questão 5")
            {
                if (resposta.Text == "")
                {
                    Pergunta6();
                }

            }
            if (label1.Text == "Questão 6")
            {
                if (resposta.Text == "")
                {
                    Pergunta7();
                }

            }
            if (label1.Text == "Questão 7")
            {
                if (resposta.Text == "")
                {
                    Pergunta8();
                }

            }
            if (label1.Text == "Questão 8")
            {
                if (resposta.Text == "")
                {
                    Pergunta9();
                }

            }
            if (label1.Text == "Questão 9")
            {
                if (resposta.Text == "")
                {
                    Pergunta10();
                }

            }

        }

        private void Pular()
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false &&
                radioButton3.Checked == false && radioButton4.Checked == false) ;
            {
                Pergunta2();
            }
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Questão 1")
            {
                if (resposta.Text == "")
                {
                    Pergunta2();
                }

            }
            if (label1.Text == "Questão 2")
            {
                if (resposta.Text == "")
                {
                    Pergunta3();
                }

            }
            if (label1.Text == "Questão 3")
            {
                if (resposta.Text == "")
                {
                    Pergunta4();
                }

            }
            if (label1.Text == "Questão 4")
            {
                if (resposta.Text == "")
                {
                    Pergunta5();
                }

            }
            if (label1.Text == "Questão 5")
            {
                if (resposta.Text == "")
                {
                    Pergunta6();
                }

            }
            if (label1.Text == "Questão 6")
            {
                if (resposta.Text == "")
                {
                    Pergunta7();
                }

            }
            if (label1.Text == "Questão 7")
            {
                if (resposta.Text == "")
                {
                    Pergunta8();
                }

            }
            if (label1.Text == "Questão 8")
            {
                if (resposta.Text == "")
                {
                    Pergunta9();
                }

            }
            if (label1.Text == "Questão 9")
            {
                if (resposta.Text == "")
                {
                    Pergunta10();
                }

            }

            if (label1.Text == "Questão 10")
            {
                this.Close(); // fechamento da tela atual
            }
        }
    }
}
