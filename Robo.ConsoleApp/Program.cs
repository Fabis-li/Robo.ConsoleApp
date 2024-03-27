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

            string[] posicaoInicial = new string[3];
            string[] novasCoordenadas = [];
            string[] areaLimite = new string[2];

            posicaoInicial = ["1","2","N"];
            areaLimite = ["5", "5"];
            novasCoordenadas = ["E","M","E","M","E","M","E","M","M"];

            char norte = 'N';
            char oeste = 'O';
            char sul = 'S';
            char leste = 'L';

        }
    }
}
