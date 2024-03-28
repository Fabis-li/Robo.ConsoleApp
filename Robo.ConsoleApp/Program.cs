namespace Robo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region instruções
            //N = norte
            //S = sul
            //L = leste
            //O = oeste
            //D = gira 90 graus para a direita
            //E = gira 90 graus para a esquerda
            //M = mover uma posicao no grid para frente

            //Entrada
            //A primeira linha deve ser as coordenadas do canto superior direito da área. O canto inferior esquerdo é sempre (0,0).
            //O resto das entradas deve ser os comandos que o robô deve executar. Cada comando deve ser enviado em 2 partes: a primeira parte é a posição inicial do robô
            //e a segunda uma série de instruções que aquele robô deve seguir para explorar a área.
            //A posição é dada com 2 inteiros e uma letra, separados por espaços, correspondendo pelas coordenadas X e Y e a orientação do robô. Cada robô vai executar as
            //instruções de forma sequencial: o segundo robô só iniciará suas ações quando o primeiro terminar.

            //Saida
            //Para cada robô, a posição final e sua orientação depois de executada as instruções.

            #endregion

            int posicaoX = 3;
            int posicaoY = 3;
            char direcao = 'L';
            int posicaoFinalX = posicaoX;
            int posicaoFinalY = posicaoY;
            //EMEMEMEMM
            //MMDMMDMDDM

            string ordem = "MMDMMDMDDM";

            for(int i = 0;i < ordem.Length; i++)
            {
                char ordemAtual = ordem[i];

                if (ordemAtual == 'E')
                {
                    if(direcao == 'N')
                    {
                        direcao = 'O';                        
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else
                    {
                        direcao = 'N';
                    }
                }
                else if (ordemAtual == 'D')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else
                    {
                        direcao = 'N';
                    }
                }
                else if (ordemAtual == 'M')
                {
                    if (direcao == 'O')
                    {
                        posicaoFinalX -= 1;
                    }
                    else if (direcao == 'S')
                    {
                        posicaoFinalY -= 1;
                    }
                    else if (direcao == 'L')
                    {
                        posicaoFinalX += 1;
                    }
                    else if (direcao == 'N')
                    {
                        posicaoFinalY += 1;
                    }

                }

            }

            Console.WriteLine($"A posição final do robo é: x:{posicaoFinalX} ,y:{posicaoFinalY} e direção:{direcao}")
            Console.ReadLine();

        }
    }
}
