using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace treinamento1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!");
            Console.WriteLine("\n");

            Console.WriteLine(3 + 3);//mostra o resultado do operador logico - comentario de varias linhas são feito dessa forma /**/
            Console.WriteLine("\n");

            Console.WriteLine("Vou 'printar' na mesma linha");// Write escreve sem pular linha (Só remover o Line);
            Console.WriteLine("\n");



            /* int - armazena inteiros (numeros inteiros), sem decimais, como 123;
             * double - armazena numeros de ponto flutuante, com decimais, como 19,99 ou -19,99;
             * char - armazena caracteres unicos, como 'a' ou 'B'. Os valores de caracteres são cercados por aspas simples; 
             * string - armazena texto, como "hello Word". Os valores de cadeia de caracteres são cercados por aspas simples ;
             * bool - armazena valores com dois estados: verdadeiro ou falso ; */

            string name = "jhon ";//declarar como string;
            Console.WriteLine(name);
            Console.WriteLine("\n");


            int myNum = 15;//declarar como inteiro ;
            Console.WriteLine(myNum);
            Console.WriteLine("\n");


            int myNum2;//declarar atribuindo o valor posteriormente ;
            myNum2 = 33;
            Console.WriteLine(myNum2);
            Console.WriteLine("\n");


            myNum = 20; // mudando o valor de myNum, ainda ira aparecer o valor antigo pois foi mudado posteriormente;
            Console.WriteLine(myNum);
            Console.WriteLine("\n");


            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum);
            Console.WriteLine("\n");


            char MyLetter = 'D';//usado para armazenar um único caractere. O personagem deve ser cercado por aspas simples, como 'A' ou 'c';
            Console.WriteLine(MyLetter);
            Console.WriteLine("\n");


            bool MyBool = true;  
            Console.WriteLine(MyBool);
            Console.WriteLine("\n");


            string MyText = "Teste pratico";  
            Console.WriteLine(MyText);
            Console.WriteLine("\n");


            const int constante = 87;
            //constante = 44 (isso causaria um erro, a variavel declarada const é imutavel)
            Console.WriteLine(constante);
            Console.WriteLine("\n");


            //somar valor com uma variavel;
            Console.WriteLine("Hello " + name);
            Console.WriteLine("\n");


            //somar duas variaveis 
            String LastName = "Pedro";
            string FullName = name + LastName;
            Console.WriteLine(FullName);
            Console.WriteLine("\n");


            //Exemplo 
            int x = 5;
            int y = 6;
            Console.WriteLine(x+y);//Soma o valor de x e y;
            Console.WriteLine("\n");


            int z = 50;// podemos somar mais de um tipo de variavel do msm tipo;
            Console.WriteLine(x+y+z);// Ja existe valor para as variaveis x e y;   se adicionar um valor string tudo será concatenado;
            Console.WriteLine("\n");


            long myNum3 = 15000000000L;//quando o número não é grande o sificient para armazenar o valor. Deve se colocar o L no final;
            Console.WriteLine(myNum3);
            Console.WriteLine("\n");


            float myNum4 = 5.75F;// colocamos  um F para ponto flutuante ;
            Console.WriteLine(myNum4);
            Console.WriteLine("\n");


            double myNum5 = 19.99D;// colocamos um D para double (é mais preciso que o float, trabalha com 64 bits );
            Console.WriteLine(myNum5);
            Console.WriteLine("\n");


            float f1 = 35e3F;// número de ponto flutuante também pode ser um número científico com um "e" para indicar a potência;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine("\n");


            bool isCSharpFun = true;// booleanos são dados com verdadeiro e falso muitos usados em condicionais ;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine("\n");


            bool isFishTasty = false;// booleano falso;
            Console.WriteLine(isFishTasty);
            Console.WriteLine("\n");


            //Conversão de tipos;

            int myInt = 9;
            double myDouble = myInt; //transforma automaticamente em double;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);// se tornou double
            Console.WriteLine("\n");


            double myDouble2 = 9.78;
            Console.WriteLine(myDouble2);
            Console.WriteLine("\n");


            int myInt2 = (int) myDouble;// transformanos o valor flutuante em inteiro; 
            Console.WriteLine(myInt2);
            Console.WriteLine("\n");


            int myInt3 = 10;
            Console.WriteLine(Convert.ToString(myInt3));// converte de inteiro para string; 
            Console.WriteLine(Convert.ToDouble(myInt3));// converte de int para double;
            Console.WriteLine("\n");


            double myDouble3 = 5.25;
            Console.WriteLine(Convert.ToInt32(myDouble3));// converte para int; o 32 significa 32 bits;
            Console.WriteLine("\n");


            bool myBool = true;
            Console.WriteLine(Convert.ToString(myBool));// converte para string ; 
            Console.WriteLine("\n");


            // Entrada do usuario ;


            /* Console.WriteLine("Olá, poderia escreva seu nome: ");
            string userName = Console.ReadLine(); //ReadLine aponta a entrda para o usuario e guarda o valor de entrada em uma variavel;
            Console.WriteLine("Bem-vindo " + userName + " !");
            Console.WriteLine("Por favor escreva sua idade : ");
            int idade = Convert.ToInt32(Console.ReadLine());// só entre com numeros e valores ineiros pois estamos nos referindo a int;
            Console.WriteLine( userName + " então sua idade é " + idade + " anos!"); */



            // Operadores Lógicos;

            int numero = 100 + 50;     //150 
            int sum1 = 100 + 50;       //150
            int sum2 = sum1 + 250;     //400
            int sum3 = sum2 + sum2;    //800

            Console.WriteLine(numero);
            Console.WriteLine(sum3);

            // Atribuição ;

            int xis = 10; // O valor de xis é 10
            xis += 5;     // Aqui atribuimos 5 a xis
            Console.WriteLine(xis);

            // Classe Math.  ;

            Console.WriteLine(Math.Max(5, 10)); // usado para encontrar o mair ; 

            Console.WriteLine(Math.Min(30, 300)); // usado para encontrar o valor minimo ; 

            Console.WriteLine(Math.Sqrt(64)); // raiz quadrada;

            Console.WriteLine(Math.Abs(-4.7));  //  retorna o valor positivo ; 

            Console.WriteLine(Math.Round(9.99)); // Arredonda para o inteiro mais proximo ; 

            // Cadeia de Caractere ;

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";       // Length usado para somar as letras da string ; 
            Console.WriteLine("O length do texto string é: " + txt.Length);

            string text = "Olá peSsoA";
            Console.WriteLine(text.ToUpper());      //Transforma tudo em maiusculo ;
            Console.WriteLine(text.ToLower());      //Transforma tudo em minusculo ; 

            // Concatenação ;

            string pName = "Skate";        // primeiro nome;
            string sName = " Surf ";       // ultimo nome;
            string nome = pName + sName;   // junção;
            Console.WriteLine(nome);

            string nome1 = "Charlie";
            string nome2 = " Brown ";
            string completo = string.Concat(nome1, nome2); //Concat para concatenar propositalmente ;
            Console.WriteLine(completo);

            // Interpolação ; 

            string name1 = " rock'n";
            string name2 = " roll";
            string rock = "O melhor tipo de musica é:"  + name1 + name2  ;
            Console.WriteLine(rock);

            string myString = "Computador"; 
            Console.WriteLine(myString[3]); // 3 caractere é p ;

            string teste = "muscia";
            Console.WriteLine(teste.IndexOf("i")); // com IndexOf escolhemos um caractere e retorna a posição dele ;

            
            string teste2 = "Carro Preto";
            int teste3 = teste2.IndexOf("P");   // localiza a letra P ;
            string arvore = teste2.Substring(teste3); // variavel recebe o valor a partir da letra que escolhemos ; ele pega o resto da string;
            Console.WriteLine(arvore);

            // Caracteres Especiais ;

            string aspasDuplas = " -> sabe aquele \"negocio\" de colocar aspas " ;  // aspas duplas são reservadas,
            Console.WriteLine("Aqui onde aparece" + aspasDuplas);                   // então usamos \" \" , como no comentario;

            string aspas = "It\'s alright.";  // Colocamos uma unica \' , para aspas simples; 
            Console.WriteLine("ASSIM APARECE O EXEMPLO DE ASPAS SIMPLES : " + aspas);

            string personagem = "O personagem \\ esta ligando";    // usamos duas contra barras na string para que apareça só uma;
            Console.WriteLine("ASSIM APARECE O EXEMPLO DE CONTRA BARRA: " + personagem );

            // Outros caracteres de escape úteis


            //  \n -> quebra linha =)
            string a1 = "Hello\nWord!";
            Console.WriteLine("Neste exemplo vemos o \\n pular uma linha: " + a1);

            //  \t -> tab
            string a2 = "Hello\tWorld!";
            Console.WriteLine("Neste outro vemos o \\t dar um espaçamento tab: " + a2);

            //  \b -> espaço
            string a3 = "Hello\tWorld!";
            Console.WriteLine("Já esse vamos o \\b dar um espaço: " + a3);


            // Valores Booleanos

            int var1 = 10;
            int var2 = 9;
            Console.WriteLine("Apresenta verdadeiro pois 10 é maior que 9: ");
            Console.WriteLine( var1 > var2 );

            int valor = 10;
            Console.WriteLine(valor == 10); // returns True, because the value of x is equal to 10

            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            // if , else ; 

            int myAge = 25;
            int votingAge = 18;

            if (myAge >= votingAge)
            {
                Console.WriteLine("Tem idade para votar!");
            }
            else
            {
                Console.WriteLine("Não tem idade para votar.");
            }
            Console.WriteLine("\n");


            // exemplo 

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Bom dia.");
            }
            else
            {
                Console.WriteLine("Boa noite.");
            }
            Console.WriteLine("\n");


            // exemplo 2


            int tempo = 22;
            if (tempo < 10)
            {
                Console.WriteLine("Boa manhã");
            }
            else if (tempo < 20) 
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
            Console.WriteLine("\n");


            // atalho 

            int hora = 20;
            string result = (hora < 18) ? "Bom dia." : "Boa noite.";
            Console.WriteLine(result);
            Console.WriteLine("\n");



            // Switch

            int day = 4;       //condicionais com blocos já preparados ;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
            Console.WriteLine("\n");


            int dia = 4;
            switch (dia)
            {
                case 6:
                    Console.WriteLine("Hoje é segunda.");
                    break;
                case 7:
                    Console.WriteLine("Hoje é terça.");
                    break;
                default:
                    Console.WriteLine("Procurando pelo dia da semana...");
                    break;
            }
            Console.WriteLine("\n");

            // loops

            int i = 0;
            while (i < 5)     //ele escrevera até i for menor que 5, quando chegar a 5, a linha de baixo não roda e entao não printa;      
            {
                Console.WriteLine(i);
                i++;          // equivalente a i = i + 1 ;
            }

            Console.WriteLine("\n");

            // condição no final ;

            int I = 0;
            do
            {
                Console.WriteLine(I);
                I++;
            }
            while (I < 5);
            Console.WriteLine("\n");

            // foe while ;

            for (int o = 0; o < 5; o++)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\n");

            
            // imprimirá apenas valores pares entre 0 e 10; pq adiciona de 2 em 2 a partir do 0;
            
            for (int u = 0; u <= 10; u = u + 2)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("\n");

            
            // Um loop dentro de outro loop. Isso é chamado de loop aninhado.

            for (int j = 1; j <= 2; ++j)                 // aqui j tem o valor de 1; para a condição ser atendida ele precisa ser 2
            {
                Console.WriteLine("Fora: " + j);         // ate a condição ser atendidade ele repete;
                for (int w = 1; w <= 3; w++)            
                {
                    Console.WriteLine("Interno: " + w);  // escreve todas as vezes que passa por aqui;
                }
            }
            Console.WriteLine("\n");


            // loop em listas

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string v in cars) // foreach; usado para percorrer uma lista ;
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");


            //break
            for (int ia = 0; ia < 10; ia++)
            {
                if (ia == 4)     
                {
                    break;
                }
                Console.WriteLine(ia);
            }
            Console.WriteLine("\n");


            // Continuar 
            for (int i1 = 0; i1 < 10; i1++)
            {
                if (i1 == 4)
                {
                    continue;
                }
                Console.WriteLine(i1);
            }
            Console.WriteLine("\n");


            int i2 = 0;
            while (i2 < 10)
            {
                if (i2 == 4)
                {
                    i2++;
                    continue;
                }
                Console.WriteLine(i2);
                i2++;
            }


            // Matriz _ arrays

            string[] caars = { "volvo" , "BMW" , "Ford" , "Mazda" };
            foreach(string marCa in caars)  
            Console.WriteLine(marCa);       
            Console.WriteLine(caars[0]);   // escolhe o local da lista;
            Console.WriteLine("\n");

            int[] listaNum = { 10, 23, 1, 45, 66 };
            foreach (int todali in listaNum) // foreach percorre a lista; 
            Console.WriteLine(todali);
            Console.WriteLine("\n");

            String[] cores = { "azul", "verde", "amarelo", "vermelho" }; // lista com cores;
            cores[3] = "roxo";                                           // escolheu o incone 3 para mudar;
            Console.WriteLine(cores[3]);                                 // imprime o incone 3 ;
            Console.WriteLine("\n");


            string[] frutas = { "maça", "pera" , "uva", "laranja" };
            Console.WriteLine(frutas.Length);                            // Length conta os elesmentos da lista;
            Console.WriteLine("\n");


            //loop atraves de uma array;
            string[] tam = { "p", "m", "g", "gg" };
            for (int tamanho = 0; tamanho < tam.Length; tamanho++)     // toda vez que passa no laço recebe um valos da array;
            {
                Console.WriteLine(tam[tamanho]);
            }
            Console.WriteLine("\n");


            //loop com foreach;
            string[] jogos = { "jogo_1", "jogo_2", "jogo_3", "jogo_4" };
            foreach (string games in jogos)
            {
                Console.WriteLine(games);
            }
            Console.WriteLine("\n");


            //multipas arrays 
            int[,] numTabe = { { 1, 4, 2, }, { 3, 6, 8 } };  // A vírgula única especifica que a matriz é bidimensional..
            Console.WriteLine(numTabe[1, 1]);                // ..Uma matriz tridimensional teria duas vírgulas;
            Console.WriteLine("\n");                         // você deve especificar dois índices:
                                                             // um para a matriz e outro para o elemento dentro dessa matriz.

            // Alterar elementos de uma matriz 2d
            int[,] numTab2 = { { 1, 4, 5}, { 3, 6, 9} };
            numTab2[0, 1] = 12;                              // Altera o valor de um indice em uma tabela;  
            Console.WriteLine(numTab2[0,1]);                 // sendo que "o primeiro indice é horintal e o segundo vertical"
            Console.WriteLine("\n");


            //loop de uma array 
            int[,] numtab3 = { { 1, 4, 7 }, { 6, 8, 3 } };
            for (int ta = 0; ta < numTabe.GetLength(0); ta++)
            {
                for (int ta2 = 0; ta2 < numTabe.GetLength(1); ta2++)
                {
                    Console.WriteLine(numtab3[ta, ta2]);
                }
            }
            Console.WriteLine("\n");


            Console.WriteLine("\n");
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadLine();// aparece no cmd, sem fechar ;
        }
    }
}


