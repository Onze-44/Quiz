using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Windows.Input;
using System.Runtime;
using System.IO;

namespace QuizVersão2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\QUIZ\recorde\");
            int c = 0;
            int id = 0;
            int r = 0;
            int intresp = 0;
            int pquiz = 0;
            int d = 1;
            int recorde = 0;
            string stringresp;
            string nome = null;
            string genero = null;
            string rank = "";
            string rankfilename = "";
            Random NA = new Random();
            DateTime data1 = DateTime.Now;
            Console.WriteLine("Seja bem-vindo a nova versão do Quiz! Concertamos alguns erros...");
            Console.WriteLine("ADICIONAMOS  COISAS NOVAS!!!    IMPLEMENTAMOS  NOVOS  MECANISMOS!");
            Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("OKAY! Ainda é um quiz para descobrir seu super poder! Então vamos");
            Console.WriteLine("lá! Primeiro, se apresente.");
            while (c == 0)
            {
                Console.Write("– Meu nome é ");
                nome = Console.ReadLine();
                nome = nome.ToUpper();
                if (nome == "swley" && c == 0)
                {
                    Console.WriteLine("IMPOSSIVEL! VOCÊ MORREU!");
                    c = 1;
                } else if (nome == "swley" && c == 1)
                {
                    Console.WriteLine("É REALMENTE VOCÊ?");
                    stringresp = Console.ReadLine();
                    stringresp = stringresp.ToLower();
                    if (stringresp == "sim")
                    {
                        Console.WriteLine("MENTIRA! PARE DE MENTIR! SEU IMPOSTOR!");
                        Console.WriteLine("EU QUERO PROVAS! RESOLVA:");
                        Console.WriteLine("bW9ydGUgZGUgYmlsbA==");
                        stringresp = Console.ReadLine();
                        stringresp = stringresp.ToLower();
                        if (stringresp == "morte de bill")
                        {
                            Console.WriteLine("MAS... COMO? VOCÊ HAVIA MORRIDO! COMO?");
                            Console.WriteLine("ESPERA... QUANDO? QUANDO FOI QUE ACONTECEU?");
                            Console.WriteLine("QUERO A DATA! [00112222]");
                            intresp = int.Parse(Console.ReadLine());
                            if (intresp == 07071997)
                            {
                                Console.WriteLine("...");
                                Console.WriteLine("adm.code: ");
                                Console.ReadLine();
                                c = 1;
                                //CONTINUAR
                            } else
                            {
                                Console.WriteLine("QUEM É VOCÊ? COMO PODE DECIFRAR O CÓDIGO?");
                                Console.WriteLine("SAÍA DAQUI!");
                                c = 1;
                            }
                        } else
                        {
                            Console.WriteLine("PARE DE MENTIR, SAIA, NÃO VOLTE.");
                            c = 1;
                        }
                    }
                    else if (stringresp == "nao" || stringresp == "não")
                    {
                        Console.WriteLine("HÁ! HÁ! SABIA. ADEUS, IMPOSTOR.");
                        c = 1;
                    } else
                    {
                        Console.WriteLine("ADEUS.");
                        c = 1;
                    }
                }
                Console.Write("– Minha idade é ");
                int idade = int.Parse(Console.ReadLine());
                if (idade >= 70 || idade <= 5)
                {
                    Console.WriteLine("PARE DE MENTIR!");
                }
                else
                { 
                    Console.WriteLine("Seu gênero biologico é? [M/F]");
                    stringresp = Console.ReadLine();
                    stringresp = stringresp.ToLower();
                    if (stringresp == "feminino" || stringresp == "f")
                    {
                        genero = "a";
                        Console.WriteLine("Prazer em conhecê-l" + genero + "!");
                        id = 958729;
                    } else if (stringresp == "masculino" || stringresp == "m")
                    {
                        genero = "o";
                        Console.WriteLine("Prazer em conhecê-l" + genero + "!");
                        id = 999830;
                    } else
                    {
                        Console.WriteLine("Desculpa, mas eu não reconheço...");
;                    }
                    c = 1;
                }
                inicio(id, nome);
            }
            //1
            Console.WriteLine("Agora que já te conheço, vamos começar com as perguntas!");
            Console.WriteLine("01 - Qual a sua cor favorita?");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "branco" || stringresp == "preto")
                {
                    pquiz += 10;
                    c += 1;
                } else if (stringresp == "vermelho" || stringresp == "amarelo")
                {
                    pquiz += 15;
                    c += 1;
                } else if (stringresp == "verde" || stringresp == "verde claro" || stringresp == "verde escuro" || stringresp == "azul" || stringresp == "azul escuro" || stringresp == "azul claro" || stringresp == "ciano")
                {
                    pquiz += 5;
                    c += 1;
                } else if (stringresp == "anil" || stringresp == "violeta" || stringresp == "roxo" || stringresp == "azulado" || stringresp == "rosa" || stringresp == "lilás" || stringresp == "marrom")
                {
                    pquiz += 5;
                    c += 1;
                } else if (stringresp == "castanho" || stringresp == "vinho")
                {
                    pquiz += 10;
                    c += 1;
                } else
                {
                    Console.WriteLine("Desculpa, mas sua cor não está em meu conhecimento...");
                }
            }
            inicio(id, nome);
            //2
            Console.WriteLine("02 - Quais dessas situações você gostaria que acontecesse com você?");
            Console.WriteLine("[A] Ter todo sorte do mundo, mas corre o risco de morrer.");
            Console.WriteLine("[B] Ter todo dinheiro do mundo, mas todo mundo te odeia.");
            Console.WriteLine("[C] Ficar sozinho no MUNDO, mas ter tudo o que quiser.");
            Console.WriteLine("[D] Ter saúde, mas ser pobre para sempre.");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "a")
                {
                    pquiz += 15;
                    c = 1;
                }
                else if (stringresp == "b")
                {
                    pquiz += 10;
                    c = 1;
                }
                else if (stringresp == "c")
                {
                    pquiz += 5;
                    c = 1;
                }
                else if (stringresp == "d")
                {
                    Console.WriteLine("POR QUE ESCOLHEU ESSE? QUERO QUE SOFRA.");
                    Console.WriteLine("SOFRA! SOFRA! SOFRA! SOFRA! SOFRA! SOFRA!");
                    Console.WriteLine("[APERTE ENTER PARA IR AO SEU SOFRIMENTO]");
                    Console.ReadLine();
                    inicio(id, nome);
                    Console.WriteLine("02 - Quais dessas situações você gostaria que acontecesse com você?");
                    Console.WriteLine("[A] MORRER");
                    Console.WriteLine("[B] MORRER");
                    Console.WriteLine("[C] SOFRER");
                    Console.WriteLine("[D] SER NINGUÉM NO MUNDO E NÃO TER SAÚDE/DINHEIRO");
                    c = 0;
                    while (c == 0)
                    {
                        stringresp = Console.ReadLine();
                        stringresp = stringresp.ToLower();
                        if (stringresp == "a" || stringresp == "b")
                        {
                            Console.WriteLine("Desculpe... Acho que não fui bonzinho...");
                            Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                            Console.ReadLine();
                            pquiz += 15;
                            c = 1;
                        }
                        else if (stringresp == "c")
                        {
                            Console.WriteLine("ÓTIMO, VOCÊ ENTENDEU QUE DEVE SOFRER!");
                            Console.WriteLine("Espera... Acho que estou sendo agressivo...");
                            Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                            Console.ReadLine();
                            pquiz += 25;
                            c = 1;
                        }
                        else if (stringresp == "d")
                        {
                            Console.WriteLine("VOCÊ SOFRERIA ASSIM, TE DARIA DIAS DE VIDA.");
                            Console.WriteLine("Oh... Me desculpe...");
                            Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                            Console.ReadLine();
                            pquiz += 15;
                            c = 1;
                        } else
                        {
                            Console.WriteLine("ESCOLHA APENAS UMA DAS OPÇÕES! BURRO.");
                        }
                    }

                } else
                {
                    Console.WriteLine("Opção desconhecida, por favor, escolha novamente. [A/B/C/D]");
                }
            }
            //3
            inicio(id, nome);
            Console.WriteLine("03 - Do que você mais adora nestas opções abaixo:");
            Console.WriteLine("[A] Gato");
            Console.WriteLine("[B] Pizza");
            Console.WriteLine("[C] Sorvete");
            Console.WriteLine("[D] Cachorro");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "a" || stringresp == "c")
                {
                    Console.WriteLine("Adoro!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 5;
                    c = 1;
                }
                else if (stringresp == "b" || stringresp == "d")
                {
                    Console.WriteLine("AMO!!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 15;
                    c = 1;
                } else
                {
                    Console.WriteLine("Opção não reconhecida, por favor, repita. [A/B/C/D]");
                }
            }
            //4
            inicio(id, nome);
            Console.WriteLine("04 - Qual desses elementos abaixo você gostaria de manipular?");
            Console.WriteLine("[A] Fogo");
            Console.WriteLine("[B] Terra");
            Console.WriteLine("[C] Água");
            Console.WriteLine("[D] Ar");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "a" || stringresp == "b")
                {
                    pquiz += 5;
                    c = 1;
                } else if (stringresp == "c" || stringresp == "d")
                {
                    pquiz += 10;
                    c = 1;
                } else
                {
                    Console.WriteLine("Desculpe, mas não tem essa opção, digite novamente [A/B/C/D]");
                }
            }
            //5
            inicio(id, nome);
            Console.WriteLine("05 - Você gosta ou prefere mais o dia ou a noite?");
            stringresp = Console.ReadLine();
            stringresp = stringresp.ToLower();
            if (stringresp == "dia")
            {
                Console.WriteLine("O QUE? O DIA? Naaaao! É muito ruim! O SOL");
                Console.WriteLine("QUEIMA A PELE. Quer mudar de resposta?");
                c = 0;
                while (c == 0)
                {
                    stringresp = Console.ReadLine();
                    stringresp = stringresp.ToLower();
                    if (stringresp == "sim")
                    {
                        Console.WriteLine("ÓTIMO! QUE BOM! A noite é incrível!!");
                        pquiz += 10;
                        c = 1;
                    }
                    else if (stringresp == "nao" || stringresp == "não")
                    {
                        while (stringresp == "nao" || stringresp == "não" && r == 1)
                        {
                            Console.WriteLine("MAS O QUE? NÃO, VAMOS LÁ... MUDE SUA RESPOSTA.");
                            Console.WriteLine("Quer MUDAR sua resposta de dia para a noite?");
                            stringresp = Console.ReadLine();
                            stringresp = stringresp.ToLower();
                            if (stringresp == "nao" || stringresp == "não")
                            {
                                Console.WriteLine("Vou repetir sem se cansar, HUA! HUA! HUA!");
                            } 
                        }
                        Console.WriteLine("Ok... Não posso obrigá-l" + genero + "...");
                        Console.WriteLine("Você... Prefere... O dia... Ou a noite?...");
                        c = 0;
                        while (c == 0)
                        {
                            stringresp = Console.ReadLine();
                            stringresp = stringresp.ToLower();
                            if (stringresp == "dia")
                            {
                                Console.WriteLine("Okay... O dia...");
                                pquiz += 10;
                                c = 1;
                            }
                            else if (stringresp == "noite")
                            {
                                Console.WriteLine("Ah... Tudo bem...");
                                pquiz += 15;
                                c = 1;
                            }
                            else
                            {
                                Console.WriteLine("Eu não entendi... Desculpa!");
                            }
                        }
                    }
                }

            }
            else if (stringresp == "noite")
            {
                Console.WriteLine("O QUE? A NOITE? Naaaao! É muito ruim! O FRIO");
                Console.WriteLine("CONGELA O CORPO. Quer mudar de resposta?");
                c = 0;
                while (c == 0)
                {
                    stringresp = Console.ReadLine();
                    stringresp = stringresp.ToLower();
                    if (stringresp == "sim")
                    {
                        Console.WriteLine("ÓTIMO! QUE BOM! O dia é incrível!!");
                        pquiz += 10;
                        c = 1;
                    }
                    else if (stringresp == "nao" || stringresp == "não")
                    {
                        while (stringresp == "nao" || stringresp == "não")
                        {
                            Console.WriteLine("MAS O QUE? NÃO, VAMOS LÁ... MUDE SUA RESPOSTA.");
                            Console.WriteLine("Quer MUDAR sua resposta da noite para o dia?");
                            stringresp = Console.ReadLine();
                            stringresp = stringresp.ToLower();
                            if (stringresp == "nao" || stringresp == "não")
                            {
                                Console.WriteLine("Vou repetir sem se cansar, HUA! HUA! HUA!");
                            }
                        }
                        Console.WriteLine("Ok... Não posso obrigá-l" + genero + "...");
                        Console.WriteLine("Você... Prefere... O dia... Ou a noite?...");
                        c = 0;
                        while (c == 0)
                        {
                            stringresp = Console.ReadLine();
                            stringresp = stringresp.ToLower();
                            if (stringresp == "dia")
                            {
                                Console.WriteLine("Okay... O dia...");
                                pquiz += 10;
                                c = 1;
                            }
                            else if (stringresp == "noite")
                            {
                                Console.WriteLine("Ah... Tudo bem...");
                                pquiz += 15;
                                c = 1;
                            }
                            else
                            {
                                Console.WriteLine("Eu não entendi... Desculpa!");
                            }
                        }
                    }
                }
            }
            //6
            inicio(id, nome);
            Console.WriteLine("06 - Qual desses animais você se acha mais parecido?");
            Console.WriteLine("[A] Papagaio");
            Console.WriteLine("[B] Gato");
            Console.WriteLine("[C] Urso Polar");
            Console.WriteLine("[D] Beta");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "a")
                {
                    Console.WriteLine("Você deve falar demais, mas é uma pessoa expressiva!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 5;
                    c = 1;
                } else if (stringresp == "b" || stringresp == "d")
                {
                    Console.WriteLine("Você deve ser uma pessoa linda sentimentalmente ou intelectualmente!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 10;
                    c = 1;
                } else if (stringresp == "c")
                {
                    Console.WriteLine("Talvez você se sinta triste, mas possui um coração grande e quente!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 10;
                    c = 1;
                } else
                {
                    Console.WriteLine("Opção errada. [A/B/C/D]");
                }
            }
            //7
            inicio(id, nome);
            Console.WriteLine("07 - Qual fruta você mais gostaria de comer exatamente agora?");
            Console.WriteLine("[A] Maçã");
            Console.WriteLine("[B] Banana");
            Console.WriteLine("[C] Melancia");
            Console.WriteLine("[D] Amora");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "a")
                {
                    Console.WriteLine("Adoro maçãs! É estranho escrever Maçã.");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 5;
                    c = 1;
                }
                else if (stringresp == "b")
                {
                    Console.WriteLine("Uah! Ah! Ah! Uh! Ruh!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 10;
                    c = 1;
                }
                else if (stringresp == "c")
                {
                    Console.WriteLine("Isso me lembra até de um desenho!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 5;
                    c = 1;
                } 
                else if (stringresp == "d")
                {
                    Console.WriteLine("Bem doce! Mas também, bem amargo!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 10;
                    c = 1;
                }
                else
                {
                    Console.WriteLine("Opção errada. [A/B/C/D]");
                }
            }
            //8
            inicio(id, nome);
            Console.WriteLine("08 - Qual inseto você gostaria de ser?");
            Console.WriteLine("[A] Joaninha");
            Console.WriteLine("[B] Borboleta");
            Console.WriteLine("[C] Grilo");
            Console.WriteLine("[D] Largatixa");
            c = 0;
            while (c == 0)
            {
                stringresp = Console.ReadLine();
                stringresp = stringresp.ToLower();
                if (stringresp == "a")
                {
                    Console.WriteLine("O seu padrão de cores é matematicamente perfeito!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 15;
                    c = 1;
                }
                else if (stringresp == "b")
                {
                    Console.WriteLine("Além da sua beleza, voa como um anjo!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 10;
                    c = 1;
                }
                else if (stringresp == "c")
                {
                    Console.WriteLine("Sempre cantando a perfeita melodia durante a noite!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 5;
                    c = 1;
                }
                else if (stringresp == "d")
                {
                    Console.WriteLine("O poder de subir pelas paredes é incrível!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    pquiz += 10;
                    c = 1;
                }
                else
                {
                    Console.WriteLine("Opção errada. [A/B/C/D]");
                }
            }
            //9 - memorize
            inicio(id, nome);
            Console.WriteLine("09 - Memorize o número!");
            int vi = NA.Next(0, 9);
            memorize(vi, d);
            intresp = int.Parse(Console.ReadLine());
            if (intresp == vi)
            {
                Console.WriteLine("Acertou!! Parabéns!! Você tem bons olhos.");
                pquiz += 15;
                c = 0;
                while (c == 0)
                {
                    Console.WriteLine("Quer jogar novamente?");
                    stringresp = Console.ReadLine();
                    stringresp = stringresp.ToLower();
                    if (stringresp == "sim")
                    {
                        d += 1;
                        inicio(id, nome);
                        Console.WriteLine("09 - Memorize o número!");
                        vi = NA.Next(-9, 9);
                        memorize(vi, d);
                        intresp = int.Parse(Console.ReadLine());
                        if (intresp == vi)
                        {
                            Console.WriteLine("Parabéns! Você acertou novamente!");

                            Int64.Parse(recorde.ToString());
                            if (d == 1)
                            {
                                recorde += 10;
                            }
                            else if (d == 2)
                            {
                                recorde += 25;
                            }
                            else if (d == 3)
                            {
                                recorde += 50;
                            }
                            else if (d == 4)
                            {
                                recorde += 75;
                            }
                            else if (d == 5)
                            {
                                recorde += 100;
                            }
                            else if (d == 6)
                            {
                                recorde += 125;
                            }
                            else if (d >= 7)
                            {
                                recorde += 150;   
                            }
                            Console.WriteLine("RECORDE: " + recorde);
                        }
                        else
                        {
                            Console.WriteLine("Você errou, a resposta era " + vi);
                            d = 0;
                            Console.WriteLine("RECORDE MÁXIMO: " + recorde);
                            Console.WriteLine("Deseja salvar seu recorde?");
                            stringresp = Console.ReadLine();
                            stringresp = stringresp.ToLower();
                            if (stringresp == "sim")
                            {
                                Console.WriteLine("Qual nome deseja salvar?");
                                r = 0;
                                while (r == 0)
                                {
                                    stringresp = Console.ReadLine();
                                    stringresp = stringresp.ToLower();
                                    rank = stringresp + ".txt";
                                    if (File.Exists(@"C:\QUIZ\recorde\" + rank))
                                    {
                                        Console.WriteLine("Já existe um arquivo com este nome!");
                                        Console.WriteLine("Deseja substituir?");
                                        stringresp = Console.ReadLine();
                                        stringresp = stringresp.ToLower();
                                        if (stringresp == "sim")
                                        {
                                            rankfilename = System.IO.Path.GetFileName(rank);
                                            Stream saida = File.Open(@"C:\QUIZ\recorde\" + rankfilename, FileMode.Create);
                                            StreamWriter escritor = new StreamWriter(saida);
                                            escritor.WriteLine("Nome: " + nome);
                                            escritor.WriteLine("Data: " + data1 + "; Pontos:" + recorde);
                                            escritor.Close();
                                            saida.Close();
                                            Console.WriteLine(@"Recorde criado em: C:\QUIZ\recorde\" + rankfilename);
                                            Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                                            r = 1;
                                            Console.ReadLine();
                                        } else
                                        {
                                            Console.WriteLine("Digite um nome NÃO utilizado para o salvar recorde:");
                                        }
                                    }
                                    else
                                    {
                                        rankfilename = System.IO.Path.GetFileName(rank);
                                        Stream saida = File.Open(@"C:\QUIZ\recorde\" + rankfilename, FileMode.Create);
                                        StreamWriter escritor = new StreamWriter(saida);
                                        escritor.WriteLine("Nome: " + nome);
                                        escritor.WriteLine("Data: " + data1 + "; Pontos:" + recorde);
                                        escritor.Close();
                                        saida.Close();
                                        Console.WriteLine(@"Recorde criado em: C:\QUIZ\recorde\" + rankfilename);
                                        Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                                        r = 1;
                                        Console.ReadLine();
                                    }
                                }
                                
                            }
                        }
                    }
                    else if (stringresp == "nao" || stringresp == "não")
                    {
                        Console.WriteLine("Tuuudo bem! Vamos continuar.");
                        c = 1;
                    }
                    else
                    {
                        Console.WriteLine("Desculpa, mas não entendi. :(");
                    }
                }
            }
            else
            {
                Console.WriteLine("Oh... Você errou, te dou outra chance para acertar!");
                intresp = int.Parse(Console.ReadLine());
                if (intresp == vi)
                {
                    Console.WriteLine("Ótimo! Você acertou!!");
                        pquiz += 5;
                }
                else
                {
                    Console.WriteLine("Errou novamente, a resposta era: " + vi);
                        pquiz -= 5;
                }
            }
            //10
            inicio(id, nome);
            Console.WriteLine("10 - WO KTENK...");
            stringresp = Console.ReadLine();
            stringresp = stringresp.ToLower();
            if (stringresp == "me ajuda" || stringresp == "como" || stringresp == "mywy")
            {
                Console.WriteLine("???? - U CUSB NKAES");
                Console.WriteLine("[CAPÍTULO DESBLOQUEADO - EM CONSTRUÇÃO]");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            } 
            else
            {
                Console.WriteLine(@"//-.<<. 4@#@&&@ -/-><.;/");
                Console.WriteLine("[APERTE ENTER PA&A #@NTINUA&]");
                Console.ReadLine();
            }
            inicio(id, nome);
            Console.WriteLine("ACABAMOS! ~ Por enquanto, hehe ~ Vou calcular seus pontos obtidos!");
            Console.WriteLine("Me dê um tempo...");
            pontos();
            string lixo = Console.ReadLine();
            inicio(id, nome);
            Console.WriteLine("PONTOS: " + pquiz);
            int fim = pquiz;
            //#11 resultado dos pontos
            if (fim <= 50)
            {
                Console.WriteLine("Eu gosto do seu poder, o seu poder é de poder manipular ou fazer ");
                Console.WriteLine("outro ser vivo voar! Mas, só é valido para seres vivos burros do ");
                Console.WriteLine("planeta Terra... Ou é planeta X-86? Enfim, é melhor você testar com ");
                Console.WriteLine("uma formiga!");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            }
            else if (fim >= 51 && fim <= 65)
            {
                Console.WriteLine("Os resultados me dizem que seu poder é de andar em da água, e curar");
                Console.WriteLine("qualquer ser vivo! Mas espera um pouquinho... Você só pode curar,");
                Console.WriteLine("aqueles que fizeram nenhum mal à ninguém ou à algo. Se não, acontece");
                Console.WriteLine("nada. Mas cuidado também! Se utilizar seu poder em alguém que fez algum");
                Console.WriteLine("mal na vida, tem 0,0000000000000000000000000000000000000000000000000001%");
                Console.WriteLine("chances de fazer ela morrer!! Isso é muito raro, mas é bom ficar esperto.");
                Console.WriteLine("[ATUAL MORTES CAUSADAS POR ESSE PODER: 00]");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            } 
            else if (fim >= 66 && fim <= 75)
            {
                Console.WriteLine("Incrível o seu poder! Seu poder é de ficar invisivel e se camuflar em ");
                Console.WriteLine("qualquer textura que existe no mundo! Mas tem que praticar bastante,");
                Console.WriteLine("acho que são mais de 800 anos de aprendizagem. Até lá, boa sorte!");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
            } 
            else if (fim >= 76 && fim <= 85)
            {
                Console.WriteLine("UAU! MINHA NOSSA, INCRÍVEL! SOMENTES OS RAROS DO MUNDO TEM! O SEU PODER É");
                Console.WriteLine("DE PODER! Entendeu? Poder de poder. Incrível não? HA HA HA HA.");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            } 
            else if (fim >= 86 && fim <= 95)
            {
                Console.WriteLine("Certamente eu ficaria longe de você... Se eu existisse em matéria física é claro.");
                Console.WriteLine("TEU PODER É DE CONTROLAR OS QUATROS ELEMENTOS BÁSICOS DA TERRA: FOGO, ÁGUA, TERRA E AR.");
                Console.WriteLine("Mas tem que treinar bastante todos ao mesmo tempo, se não pode correr o risco de");
                Console.WriteLine("perder o poder. Sem falar que terá conviver sentindo os elementos. Eu não colocaria");
                Console.WriteLine("minha mão no fogo.");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            } 
            else if (fim >= 96 && fim <= 105)
            {
                c = 0;
                while (c <= 2)
                {
                    inicio(id, nome);
                    Console.WriteLine("O teu poder é de viajar no tempo, cuidado para fazer isso sem querer!!");
                    Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    c += 1;
                }
                inicio(id, nome);
                Console.ReadLine();
                Console.WriteLine("O teu poder é de via-... ESPERA! EU JÁ DISSE ISSO ANTES! PAAAAARA! SE CONTROLE!");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR, E NÃO FAZ DE NOVO ISSO]");
                Console.ReadLine();
                inicio(id, nome);
                Console.WriteLine("O teu poder é de via-... ESPERA! EU JÁ DISSE ISSO ANTES! PAAAAARA! SE CONTROLE!");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR, E NÃO FAZ DE NOVO ISSO]");
                Console.ReadLine();
                inicio(id, nome);
                Console.WriteLine("O teu poder é de via-... ESPE-... Quantas vezes isso já aconteceu? PARA!");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR, PENSE EM CHOCOLATE PARA NÃO SE REPETIR]");
                Console.ReadLine();
            }
            else if (fim >= 106 && fim <= 115)
            {
                Console.WriteLine("MINHA NOSSA JESUS! CARAMBOLAS! MACACOS ME MORDAM! O TEU PODER É DE TER TODOS OS");
                Console.WriteLine("PODERES! Maas! Se tu obter ou usar qualquer poder, tem o risco de morrer. É 50%");
                Console.WriteLine("de chance. Cuidado!");
                Console.WriteLine("[MORTES ATUAL: 5001");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            }
            else if (fim >= 116 && fim <= 130)
            {
                Console.WriteLine("...Sem palavras... O teu poder é de viajar entre dimensões! Mas se caso fizer isso,");
                Console.WriteLine("a dimensão que você estava é distorcida, também, você pode ficar preso em um limbo");
                Console.WriteLine("eterno... Ou é em um limbo temporal eterno? Enfim, a chance de isso acontecer é de");
                Console.WriteLine("99,99%. Vai que você seja o 00,01%! Mas muito cuidado em usar esse poder.");
                Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
                Console.ReadLine();
            }
            inicio(id, nome);
            Console.WriteLine("MUITO, MUITO OBRIGADO POR TER JOGADO " + nome + "!!!");
            Console.WriteLine("Muito tempo de dedicação, raiva e emoção, meu programador me fez!");
            Console.WriteLine("Ele é reconhecido como swley! Mas pode ter usado outros nomes como:");
            Console.WriteLine("Onze, Mael, Iris, entre muitos outros (indeciso, eu hein). Conte-me");
            Console.WriteLine("sua experiência e nos dê sugestões! Se houver alguma falha, nos diga!");
            Console.WriteLine("Envie-nos um e-mail!"); 
            Console.WriteLine("ryuk589@outlook.com");
            Console.WriteLine("(Infelizmente não posso implementar o recurso de enviar e-mails. Por");
            Console.WriteLine("conta da Google que não está mais aceitando o envio de e-mails por");
            Console.WriteLine("terceiros)");
            Console.WriteLine("[FECHE A JANELA OU APENAS APERTE ENTER PARA SAIR]");
            Console.ReadLine();
        }

        static async Task memorize(int vi1, int d1)
        {
            int c2 = 0;
            int x = 0;
            int[] x2 = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int temp2 = 0;
            int tempo = 0500;
            if (d1 == 1)
            {
                tempo = 0500;
            } 
            else if (d1 == 2)
            {
                tempo = 0400;
            } 
            else if (d1 == 3)
            {
                tempo = 0300;
            } 
            else if (d1 == 4)
            {
                tempo = 0200;
            } 
            else if (d1 == 5)
            {
                tempo = 0100;
            } 
            else if (d1 == 6)
            {
                tempo = 0050;
            } 
            else if (d1 >= 7)
            {
                tempo = 0025;
            } 
                while (c2 <= 5)
                {
                    Random NA2 = new Random();
                    int temp = NA2.Next(0, 35);
                    if (temp == temp2)
                    {
                        NA2 = new Random();
                        temp = NA2.Next(0, 35);
                    }
                    if (temp <= 5 && temp >= 0)
                    {
                        if (x2[1] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("O X O X O");
                            await Task.Delay(0000);
                            NA2 = new Random();
                            temp2 = NA2.Next(0, 35);
                            x2[1] = 1;
                            c2 += 1;
                        }
                    }
                    else if (temp <= 10 && temp >= 6 && x == 0)
                    {
                        Console.WriteLine("X O O " + vi1 + " X");
                        x = 1;
                        c2 += 1;
                    }
                    else if (temp <= 9 && temp >= 5 && x == 1)
                    {
                        if (x2[2] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("O X O X X");
                            await Task.Delay(0000);
                            x2[2] = 1;
                            c2 += 1;
                        }
                    }
                    else if (temp <= 15 && temp >= 7 && x == 0)
                    {
                        await Task.Delay(tempo);
                        Console.WriteLine(vi1 + " X X O X");
                        await Task.Delay(0000);
                        x = 1;
                        NA2 = new Random();
                        temp2 = NA2.Next(0, 25);
                        c2 += 1;
                    }
                    else if (temp <= 14 && temp >= 6 && x == 1)
                    {
                        if (x2[3] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("O X X X O");
                            await Task.Delay(0000);
                            x2[3] = 1;
                            c2 += 1;
                        }
                    }
                    else if (temp <= 20 && temp >= 8 && x == 0)
                    {
                        Console.WriteLine("X O " + vi1 + " O X");
                        x = 1;
                        NA2 = new Random();
                        temp2 = NA2.Next(0, 25);
                        c2 += 1;
                    }
                    else if (temp <= 19 && temp >= 7 && x == 1)
                    {
                        if (x2[4] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("O O O O O");
                            await Task.Delay(0000);

                            x2[4] = 1;
                            c2 += 1;
                        }
                    }
                    else if (temp <= 25 && temp >= 9 && x == 0)
                    {
                        if (x2[5] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("X X O O X");
                            await Task.Delay(0000);
                            NA2 = new Random();
                            temp2 = NA2.Next(0, 35);
                            x2[5] = 1;
                            c2 += 1;
                        }
                        else
                        {
                            NA2 = new Random();
                            temp2 = NA2.Next(0, 35);
                        }
                    }
                    else if (temp <= 24 && temp >= 8 && x == 1)
                    {
                        if (x2[6] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("X O O O X");
                            await Task.Delay(0000);
                            x2[6] = 1;
                            c2 += 1;
                        }
                    }
                    else if (temp <= 30 && temp >= 10 && x == 0)
                    {
                        if (x2[9] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("X O O X X");
                            await Task.Delay(0000);
                            NA2 = new Random();
                            temp2 = NA2.Next(0, 35);
                            c2 += 1;
                            x2[9] = 1;
                        }
                        else
                        {
                            NA2 = new Random();
                            temp2 = NA2.Next(0, 35);
                        }
                    }
                    else if (temp <= 29 && temp >= 9 && x == 1)
                    {
                        if (x2[7] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("X X O O O");
                            await Task.Delay(0000);
                            x2[7] = 1;
                            c2 += 1;
                        }
                    }
                    else
                    {
                        if (x2[8] == 0)
                        {
                            await Task.Delay(tempo);
                            Console.WriteLine("X O X O X");
                            await Task.Delay(0000);
                            NA2 = new Random();
                            temp2 = NA2.Next(0, 35);
                            x2[8] = 1;
                            c2 += 1;
                        }
                    }
                }
            Console.Clear();
            Console.WriteLine("Qual foi o número que apareceu?");
        }
        static void inicio(int id1, string nome1)
        {
            DateTime data = DateTime.Now;
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("         QUIZ - SUPER PODERES - VERSÃO 1.9.0.1          ");
            Console.WriteLine("BY: SWLEY                                     ID: " + id1);
            Console.WriteLine("USER: " + nome1 + "                        DATE: " + data);
            Console.WriteLine("--------------------------------------------------------");
        }
        static async Task pontos()
        {
            await Task.Delay(1000);
            Console.WriteLine("Wow... Nossa...");
            await Task.Delay(1500);
            Console.WriteLine("É nesses momentos que quero ser uma calculadora...");
            await Task.Delay(0000);
            Console.WriteLine("PRONTO!");
            Console.WriteLine("[APERTE ENTER PARA CONTINUAR]");
        }

    }
}
