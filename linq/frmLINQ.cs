using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linq
{
    //=====================================================
    // projeto para testar instruções LINQ em C#
    //=====================================================
    public partial class frmLINQ : Form
    {
        List<int> lista_numeros;
        List<string> lista_nomes;
        Dictionary<string, double> lista_produtos;
        List<cl_alunos> lista_alunos;
        DataTable dados;

        //=================================================
        public frmLINQ()
        {
            InitializeComponent();

            //carrega os dados das coleções
            cl_colecoes colecoes = new cl_colecoes();
            lista_numeros = colecoes.lista_numeros;
            lista_nomes = colecoes.lista_nomes;
            lista_produtos = colecoes.lista_produtos;
            lista_alunos = colecoes.lista_alunos;
            dados = colecoes.dados;
        }

        //=================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            //apresenta o número de registos em cada coleção na listbox ao iniciar o programa
            lista.Items.Add("lista_numeros = " + lista_numeros.Count + " números.");
            lista.Items.Add("lista_nomes = " + lista_nomes.Count + " nomes.");
            lista.Items.Add("lista_produtos = " + lista_produtos.Count + " produtos.");
            lista.Items.Add("lista_alunos = " + lista_alunos.Count + " alunos.");
            lista.Items.Add("dados (DataTable) = " + dados.Rows.Count + " linhas.");
        }

        //=================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //fecha a aplicação
            Application.Exit();
        }

        //=================================================
        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //execução dos testes
            lista.Items.Clear();
            label_resultado.Text = "";
            //"lista" é o listbox1 
            //.field<string> .field<int> otimo para substituir ToString.
            //AsEnumerable() para pesquisa no banco de dados

            //===============================================================================

            #region APRESENTA A LISTA_NOME CRIADA
            //foreach (string nome in lista_nomes)
            //    lista.Items.Add(nome);

            //para procurar a palavra "Ribeiro" ou mais de duas palavras ou letras etc..(se eu quiser só uma é só apagar os || nom.Contains("Ribeiro")
            //var nomes = from nom in lista_nomes
            //            where nom.Contains("Silva") || nom.Contains("Ribeiro")
            //            select nom;
            //foreach (string n in nomes)
            //    lista.Items.Add(n);
            #endregion
            //===============================================================================

            #region APRESENTA A LISTA_NUMEROS CRIADA
            //foreach (int i in lista_numeros)
            //    lista.Items.Add(i.ToString());
            #endregion
            //===============================================================================

            #region APRESENTA TODOS OS PRODUTOS QUE COMECE POR TAL LETRA
            //var resultados = from item in lista_produtos
            //                 where item.Key.StartsWith("M") //public Dictionary<string(key), double(value)>
            //                 select item;
            //foreach (KeyValuePair<string, double> resul in resultados) //repare que por conta do dictionary eu preciso por desta maneira KeyValuePair<string, double>
            //lista.Items.Add(resul.Key); //se eu quiser apresentar so as keys(string, ou nomes) tenho que colcoar .Key, para apresentar os valores coloco .Value
            //caso eu deixe assim lista.Items.Add(resul); vai aparecer os nomes e os resuldados

            //----------PODEMOS ESCREVER ESSE CODIGO ACIMA /\ COM (LAMBDA) VEJA ABAIXO \/------------------------
            // sinal da função lambda "=>"
            //é mais correto fazer o lambda ! 
            //var resultados = lista_produtos.Where(produto => produto.Key.StartsWith("M"));
            //foreach (KeyValuePair<string, double> resul in resultados)
            //lista.Items.Add(resul.Key);//se eu quiser apresentar so as keys(string, ou nomes) tenho que colcoar .Key, para apresentar os valores coloco .Value
            //caso eu deixe assim lista.Items.Add(resul); vai aparecer os nomes e os resuldados

            #endregion
            //===============================================================================

            #region ORDERNAR LISTA POR ORDEM CRESCENTE, DECRESCENTE OU ALFABETICA
            //*ordem crescente
            // var numeros = from numero in lista_numeros
            // orderby numero
            // select numero;
            // foreach (int numero in numeros)
            // lista.Items.Add(numero);

            //-------------------------------------------------------------------

            //*ordernar os nomes por ordem alfabetica (a ao z)
            // var turma = from aluno in lista_alunos
            // where aluno.sexo == "masculino" //caso queria eu mostrar por ordem alfabetica só os alunos do sexo masculino
            // orderby aluno.nome // não precisa colocar mais aqui vai o "ascending"
            // select aluno;
            // foreach (cl_alunos aluno in turma)//repare que tenho que por o cl_alunos
            // lista.Items.Add(aluno.nome);//repare que aqui tenho que por aluno.nome

            //--------------------------------------------------------------------

            //*ordernar os nomes por ordem alfabetica porém de baixo para cima (z ao a)
            // var turma = from aluno in lista_alunos
            // orderby aluno.nome descending //só colocar o "descending"
            // select aluno;
            // foreach (cl_alunos aluno in turma)
            // lista.Items.Add(aluno.nome);

            //--------------------------------------------------------------------

            //*ordernar os nomes por numero de letras no nome ou seja do nome mais curto para o nome com mais letras
            // var turma = from aluno in lista_alunos
            // orderby aluno.nome.Length //só colocar o .lenght
            // select aluno;
            // foreach (cl_alunos aluno in turma)
            // lista.Items.Add(aluno.nome); //lista.Items.Add(aluno.nome + " (" + aluno.nome.Length + ")"); para mostrar entre "()" a quantidade de letras

            //-------------------------------------------------------------------

            //*ordernar os produtos por ordem alfabetica (a ao z) e ordem alfabetica de baixo para cima (z ap a)
            // var produtos = from produto in lista_produtos
            // orderby produto.Key //"ascending" ordem alfabetica (a ao z) /só alterar/ "descending" de baixo para cima (z ao a)
            // select produto;
            // foreach (KeyValuePair<string, double> produto in produtos)
            // lista.Items.Add(produto.Key);

            //-------------------------------------------------------------------

            //*transformar o codigo acima em lambda (lambda otimiza o código porém ele tem a mesma função que o de cima /\
            // var produtos = lista_produtos.OrderBy(i => i.Key);//ordem alfabetica (a ao z)
            //// var produtos = lista_produtos.OrderByDescending(i => i.Key);//ordem alfabetica debaixo para cima (z ao a)


            // foreach (KeyValuePair<string, double> protudo in produtos)
            // lista.Items.Add(protudo.Key);

            #endregion
            //===============================================================================

            #region SOMAR/MEDIA lista_numero, APRESENTAR VALORES MINIMOS E VALORES MAXIMOS
            //*vai mostrar a quantidades de numero no label
            // label_resultado.Text = lista_numeros.Count().ToString();

            //-------------------------------------------------------------------------------

            //*vai mostrar a quantidades de numero menor que 20 no label
            // int contagem = (from lista in lista_numeros
            //  where lista < 20
            //  select lista).Count();            
            // label_resultado.Text = contagem.ToString();

            //-------------------------------------------------------------------------------

            //*vai mostrar os numeros menor que 20 no textbox
            // var valores = from lista in lista_numeros
            // where lista < 20
            // select lista;
            // foreach (var valor in valores)
            // lista.Items.Add(valor);

            //-------------------------------------------------------------------------------

            //*vai somar todos os numeros do lista_numeros e apresentar na label 
            // label_resultado.Text = "O somatorio dos valores é " + lista_numeros.Sum();//sum soma tudo
            // foreach (int v in lista_numeros)//para mostrar na listbox os numeros
            // lista.Items.Add(v);//para mostrar na listbox os numeros

            //(*lambda*)
            ///*versão do codigo acima em lambda (somatorio dos valors menores que 20)
            // label_resultado.Text = "O somatorio dos valores é " + lista_numeros.Where(i => i < 20).Sum();

            //*apresentar o valor minimo na label
            // label_resultado.Text = "MIN " + lista_numeros.Min();

            //*apresentar o valor maximo na label
            // label_resultado.Text = "MAX " + lista_numeros.Max();

            //*apresentar o nome mais curto na label
            // int curto = lista_nomes.Min(i => i.Length);
            // label_resultado.Text = "O nome com numero de letras mais curto tem essa quantidade de caracter: " + curto;

            //*apresenta o nome mais grande na label
            // int grande = lista_nomes.Max(i => i.Length);
            // label_resultado.Text = "O nome com o numero de letras maior tem essa quantidade de caracter: " + grande;

            //-------------------------------------------------------------------------------

            //*valor da media dos numeros na lista_numeros(double por conta da casa decimal)
            // double media = lista_numeros.Average();
            // label_resultado.Text = media.ToString();
            #endregion
            //===============================================================================

            #region APRESENTA OS NUMEROS DA LISTA_NUMEROS QUE SEJA MENOR QUE 20
            /*
            var numeros = from num in lista_numeros //selecionar a partir da lista_numeros um valor que vai chamar "num"
                          where num <= 20 //vai mostrar os valores que seje menor ou igual a 20
                          select num; //caso houver numeros menores ou iguais a 20 ele vai mostrar no textbox

            //apresentar os resultados acima /\ na textbox \/
            foreach (int num in numeros)
                lista.Items.Add(num.ToString())
            */
            #endregion
            //===============================================================================

            #region FIRST(primeiro numero ou numero)/elementAt(indice, escolhe os nomes ou numeros a ser mostrado)
            //*First pegando o primeiro numero
            //List<int> numero = new List<int>() { 10, 20, 30, 40 };//é preciso inserir valores aqui se não da erro
            // label_resultado.Text = numero.First().ToString(); //first vai pegar o primeiro valor ou posso por indice "label_resultado.Text = numero[0].First().ToString();"
            // label_resultado.Text = numero.FirstOrDefault().ToString();//se nao existir valor dentro do {} ele assumir o valor 0 e não vai dar erro

            //---------------------------------------------------------------------

            //*First pegando o primeiro nome
            // label_resultado.Text = lista_nomes.FirstOrDefault();//ele vai mostrar o 1 nome, caso não tenha ele não aparece nada e nao da erro
            //label_resultado.Text = lista_nomes.First();//ele vai mostrar o 1 nome, caso nao tenha nomes ele vai dar erro.

            //---------------------------------------------------------------------

            //*ElementAt mostrar os nomes ou numeros por indice
            // label_resultado.Text = lista_nomes.ElementAt(2);//mostra o nome numero 2
            //fazendo em lambda \/
            // label_resultado.Text = lista_nomes.Where(i => i.Contains("Ribeiro")).ElementAt(1);//repare vai aparecer o 2 nome com ribeiro (lembre-se 0,1,2,3)



            #endregion
            //===============================================================================

            #region APRESENTA OS NUMEROS (DA LISTA_NUMEROS )QUE SEJA MENOR QUE 10 E SUPERIOR A 20 (ADICIONANDO CRITERIO DE RESTRIÇÃO "&&" ou "||")apresentar os numeros que seja menor que 10 e superior a 20(adicionando criterio de restrição)
            //var numeros = from num in lista_numeros
            //              where num <= 10 || num >= 20
            //              select num;
            //foreach (int num in numeros)
            //    lista.Items.Add(num.ToString());
            //&& = o mesmo que escrever "and" porém na programação é &&
            //|| = o mesmo que escrever "or" porém na programação é ||


            #endregion
            //===============================================================================

            #region PESQUISAR TODOS OS NOMES DOS ALUNOS + CONCATENAÇÃO
            // var resultado = from aluno in lista_alunos
            // select aluno.nome; //repare que quando eu coloco select aluno; eu preciso por um "." apos o aluno, exemp aluno. pois isso vai aparece as propriedades criada na classe que sao (EXAMES, nome,numero,sexo)
            // foreach (string n in resultado) //ali na string eu preciso por o valor de cada propriedade, aluno é do tipo string, se tiver uma do tipo INT colocar int ao invez de string
            // lista.Items.Add(n);

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //*concatenar para aparecer numero do aluno e o nome dele
            // var resultado = from aluno in lista_alunos
            // select aluno;
            // foreach (cl_alunos n in resultado)// veja que aqui eu ja preciso por cl_alunos
            // lista.Items.Add("o aluno nº " + n.numero + " é " + n.nome);

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //*repare como o 1 exemplo da para fazer a mesma coisa que o exemplo acima /\
            // var resultados = from aluno in lista_alunos
            // select "O aluno nº " + aluno.numero + " é " + aluno.nome; //porém ao inves de "n" eu coloco "aluno"
            // foreach (string n in resultados)
            // lista.Items.Add(n);                

            #endregion
            //===============================================================================

            #region SELECIONAR APENAS ALGUNS NOMES PARA MOSTRAR NA TABELA
            // int[] indices = new int[] { 1, 2, 3 }; //posso inverter tambem e os nomes aparece invertido

            // var resultados = from indice in indices
            // select lista_nomes[indice];

            // foreach (string nome in resultados)
            //lista.Items.Add(nome);
            #endregion
            //===============================================================================

            #region ALTERANDO O NOME DA STRING DA PROPRIEDADE (não é necessasrio mais só para exemplo)
            // var turma = from a in lista_alunos
            // select new { num = a.numero, nom = a.nome, sex = a.sexo };
            // foreach (var aluno in turma) //repare que ao fazer essa alteração é necessario por "VAR" pois é anonimo ou indefinido
            // lista.Items.Add(aluno.nom);//repare que ao colocar "aluno." aparece os novos nomes das variaves(propriedades) que alterei acima /\
            #endregion
            //===============================================================================

            #region PESQUISAR O NUMERO DE ALUNAS
            ////saber quantos alunos são do sexo feminino
            // int numero_alunas = (from aluno in lista_alunos
            //                     where aluno.sexo == "feminino"
            //                     select aluno).Count();
            //label_resultado.Text = "Esta turma tem " + numero_alunas + " alunas.";
            //label_resultado.Text = string.Format("Esta turma tem {0} alunas.", numero_alunas); //com o format vai ficar assim "Esta turma tem "5" alunas. (repare que a quantidade de alunas vai substituir o {0} por causa do format.
            //exp = label_resultado.Text = string.Format("Esta turma tem {0} alunas, e {0} alunos.", numero_alunas, lista_nomes);//caso tenha um segundo argumento como "lista_nomes" colocar outro {0} como no exemplo.

            ////-----------OUTRA FOMRA DE SABER QUANTAS ALUANS TEM \/-----------------------

            ////numero de alunas (lambda)
            //int numero_alunas = lista_alunos.Where(i => i.sexo == "feminino").Count();
            //label_resultado.Text = "Numero alunas: " + numero_alunas;
            #endregion
            //===============================================================================

            #region SABER OS RESULTADOS DOS EXAMES DE MATEMATICA 
            //var notas_matematica = from nota in lista_alunos
            //                      select nota.EXAMES[0];//[0] porque é a matematica, o [1] é o ingles e por assim vai...
            //foreach (var nota in notas_matematica)
            //    lista.Items.Add("Nota de matemática = " + nota.nota_exame);//posso por nota_exame aqui porque ele sabe que o indice é [0] de matematica

            ////--------OUTRA FORMA DE SABER RESULTADOS DO EXAME DE MATEMATICA \/--------------------------

            //*lista de notas do exame de matemática (lambda)
            //var notas = lista_alunos.Select(i => i.EXAMES[0]);
            //foreach (var nota in notas)
            //    lista.Items.Add(nota.nota_exame);//posso por nota_exame aqui porque ele sabe que o indice é [0] de matematica

            //-----------------------------------------------------------------------------

            //*para saber numero de alunas que fez o exame de matematica (formato lambda)
            // var numero_alunas = lista_alunos.Where(i => i.sexo == "feminino").Count();
            // label_resultado.Text = "Numero alunas " + numero_alunas;

            //-----------------------------------------------------------------------------

            //*para saber quantos alunos tiveram nota positiva no exame de matematica
            // int positivo_matematica = (from aluno in lista_alunos
            //                            where aluno.EXAMES[0].nota_exame >= 10
            //                            select aluno).Count();
            // label_resultado.Text = string.Format("Na turma, {0} alunos tiveram nota positiva no exame de matematica.", positivo_matematica);

            //------------------------------------------------------------------------------

            //*para saber quantos alunos tiveram nota positiva no exame de matematica(lambda)
            // int positivo_matematica = lista_alunos.Where(i => i.EXAMES[0].nota_exame >= 10).Count();
            // label_resultado.Text = string.Format("Na turma, {0} alunos tiveram nota positiva no exame de matematica.", positivo_matematica); //o {0} vai ser substituido pelo "positivo_matematica" e vai apresentar o resultado ou seja vai aparecer o numero 8


            #endregion
            //===============================================================================

            #region SABER QUANTOS ALUNOS TIVERAM NOTA POSITIVA NO EXAME DE MATEMATICA
            //int positivas_matematica = lista_alunos.Where(i => i.EXAMES[0].nota_exame >= 10).Count();
            //label_resultado.Text = string.Format("Na turma, {0} alunos tiveram positiva a Matemática.", positivas_matematica);

            ////-------OUTRA FORMA DE SABER QUANTOS ALUNOS TIVERAM NOTA POSITIVA NO EXAME DE MATEMATICA---------

            //int positivas_matematica = (from aluno in lista_alunos
            //                            where aluno.EXAMES[0].nota_exame >= 10
            //                            select aluno).Count();
            //label_resultado.Text = string.Format("Na turma, {0} alunos tiveram positiva a Matemática.", positivas_matematica);
            #endregion
            //===============================================================================

            #region SABER MEDIA DE NOTAS DO EXAME DE MATEMATICA
            //*apresenta a media dos alunos (lambda)
            //double media_matematica = lista_alunos.Average(i => i.EXAMES[0].nota_exame);//Average significa média
            //label_resultado.Text = string.Format("A média dos exames de Matemática foi {0} valores.", media_matematica);

            //------------------------------------------------------------

            //*apresenta a media dos alunos
            //double media_matematica = (from aluno in lista_alunos
            //                           select aluno.EXAMES[0].nota_exame).Average();

            //label_resultado.Text = string.Format("A média dos exames de Matemática foi {0} valores.", media_matematica);
            #endregion
            //===============================================================================

            #region SABER MEDIA DE NOTAS DO EXAME DE BIOLOGIA
            //*apresenta a media de biologia (lambda)
            // var nota_biologia = lista_alunos.Select(i => i.EXAMES[2].nota_exame);// [2] porque biologia é o 2!
            // foreach (var nota in nota_biologia)
            //    lista.Items.Add(nota);

            //-----------------------------------------------------------

            //*apresentar as medias positivas e separar as negativas das positivas
            // double media_biologia = lista_alunos.Where(i => i.EXAMES[2].nota_exame >= 10).Average(i => i.EXAMES[2].nota_exame);
            // label_resultado.Text = string.Format("A media positiva de biologia é de {0}", media_biologia);
            #endregion
            //===============================================================================

            #region SABER MEDIA DE NOTAS DO EXAME DE BIOLOGIA
            //var notas_biologia = lista_alunos.Select(i => i.EXAMES[2].nota_exame);
            //foreach (var nota in notas_biologia)
            //    lista.Items.Add(nota);

            //----------------------------------
            //média das positivas de biologia
            //double media_biologia = lista_alunos.Where(i => i.EXAMES[2].nota_exame >= 10).Average(i => i.EXAMES[2].nota_exame);
            //label_resultado.Text = string.Format("A média das positivas de biologia é {0} valores.", media_biologia);
            #endregion
            //===============================================================================

            #region SABER MEDIA DE NOTAS DE CADA ALUNO / MELHOR ALUNO / MEDIA
            //var notas = from aluno in lista_alunos
            //            select new
            //            {
            //                nome = aluno.nome,
            //                media = (aluno.EXAMES[0].nota_exame +
            //                         aluno.EXAMES[1].nota_exame +
            //                         aluno.EXAMES[2].nota_exame +
            //                         aluno.EXAMES[3].nota_exame) / 4 //pega a nota de todos os exames que são 4  e divide por 4
            //            };

            //foreach (var nota in notas)
            //    lista.Items.Add(nota.nome + " - " + nota.media);

            //-------------------------------------------------------------

            //*saber as melhores notas de matematica por ordem decrescente(as maiores primeiros e as menores em baixo)
            //var alunos = (from aluno in lista_alunos
            //              select new
            //              {
            //                  nome = aluno.nome,
            //                  nota_matematica = aluno.EXAMES[0].nota_exame
            //              }
            //             ).OrderByDescending(i => i.nota_matematica); //repare como aqui preciso por orderbydescending para a ordem descrecente
            //foreach (var aluno in alunos)
            //    lista.Items.Add(aluno.nome + " - " + aluno.nota_matematica);

            //-------------------------------------------------------------

            //*apresenta o melhor aluno no geral
            //var alunos = (from aluno in lista_alunos //aqui esta todos os alunos
            //              select new
            //              {
            //                  nome = aluno.nome,
            //                  total_notas = aluno.EXAMES.Select(i => i.nota_exame).Sum() //aqui soma todas as notas dos exames de todos os alunos
            //              }
            //             ).OrderByDescending(i => i.total_notas);
            //foreach (var aluno in alunos)
            //    lista.Items.Add(string.Format("{0} tem um total de {1} nota.", aluno.nome, aluno.total_notas)); // nao coloque + coloque ,
            //                                //{0} vai ser o nome do aluno, {1} vai ser a nota do aluno

            #endregion
            //===============================================================================

            #region SABER A LISTAGEM DE NOTAS DE MATEMATICA POR ORDEM DECRESCENTE 
            //var alunos = (

            //             from aluno in lista_alunos
            //             select new
            //             {
            //                 nome = aluno.nome,
            //                 nota_matematica = aluno.EXAMES[0].nota_exame
            //             }

            //             ).OrderByDescending(i => i.nota_matematica);

            //foreach (var aluno in alunos)
            //    lista.Items.Add(aluno.nome + " - " + aluno.nota_matematica);
            #endregion
            //===============================================================================

            #region SABER QUAL È MELHOR ALUNO NO GERAL
            //var alunos = (from aluno in lista_alunos
            //              select new
            //              {
            //                  nome = aluno.nome,
            //                  total_notas = aluno.EXAMES.Select(i => i.nota_exame).Sum()
            //              }
            //             ).OrderByDescending(i => i.total_notas);

            //foreach (var aluno in alunos)
            //    lista.Items.Add(string.Format("{0} tem um total de {1} valores.", aluno.nome, aluno.total_notas));
            #endregion
            //===============================================================================

            #region DATATABLE
            //*mostrando todos os dados do dados.txt
            //foreach (DataRow linha in dados.Rows)
            //{
            //    lista.Items.Add(string.Format("id_cliente = {0} | nome_cliente = {1} | cidade = {2} | num. encomendas = {3}",
            //                    linha["id_cliente"].ToString(), linha["nome_cliente"].ToString(),
            //                    linha["cidade"].ToString(), linha["numero_encomendas"].ToString()));
            //}

            //------------------------------------------------------------------------

            //*apresentar somente o nome dos clientes
            //var clientes = from cliente in dados.AsEnumerable() //Enumerable = usado em expressoes linq para transformar em datarows
            //               select cliente["nome_cliente"].ToString();
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente);

            //------------------------------------------------------------------------

            //*apresentar somente o nome dos clientes de outra maneira usando o FIELD
            //var clientes = from cliente in dados.AsEnumerable()
            //               select cliente.Field<string>("nome_cliente");//repare que em cima transformei em string "ToString" aqui eu usei o FIELD para transformar numa string
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente);

            //------------------------------------------------------------------------

            //*apresentar somente os clientes por ordem alfabetica (melhor forma usando o field)
            //var clientes = (from cliente in dados.AsEnumerable()
            //                select cliente.Field<string>("nome_cliente")).OrderBy(i => i);//o (i => i) esta como string por causa do field e com isso vai listar em ordem alfabetica
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente);

            //------------------------------------------------------------------------

            //*apresentar somente os clientes por ordem alfabetica de outra maneira
            //var clientes = (from cliente in dados.AsEnumerable()
            //                select new
            //                {
            //                    nome = cliente.Field<string>("nome_cliente")

            //                }
            //               ).OrderBy(i => i.nome);
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome);

            //------------------------------------------------------------------------

            //*apresentar o cliente que tem maior numero de encomendas
            //var clientes = (from cliente in dados.AsEnumerable()
            //                select new
            //                {
            //                    nome = cliente.Field<string>("nome_cliente"),
            //                    numero_encomendas = cliente.Field<int>("numero_encomendas")
            //                }
            //               ).OrderByDescending(i => i.numero_encomendas); //OrderByDescending do maior para o menor
            //foreach (var cliente in clientes)
            //    lista.Items.Add(string.Format("O cliente {0} tem {1} numero de encomendas", cliente.nome, cliente.numero_encomendas));

            //------------------------------------------------------------------------

            //*apresenta somente as cidades
            //var clientes = from cliente in dados.AsEnumerable()
            //               select new
            //               {
            //                   cidade = cliente.Field<string>("cidade")

            //               };
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.cidade);

            //------------------------------------------------------------------------

            //*apresenta nome dos clientes e cidades
            //var clientes = from cliente in dados.AsEnumerable()
            //               select new
            //               {    
            //                   nome = cliente.Field<string>("nome_cliente"),
            //                   cidade = cliente.Field<string>("cidade")

            //               };
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome + " - " + cliente.cidade);

            //

            //*apresenta nome dos clientes e cidade com filtro
            //var clientes = from cliente in dados.AsEnumerable()
            //               where cliente.Field<string>("cidade") == "Rio de Janeiro" //vai apresentar somentes os clientes do rio de janeiro
            //               select new
            //               {
            //                   nome = cliente["nome_cliente"].ToString(),//posso escrever com ToString
            //                   cidade = cliente.Field<string>("cidade")//ou posso escrever com Field(mais pratico)

            //               };
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome + " - " + cliente.cidade);

            #endregion
            //===============================================================================

            #region PESQUISAR NOMES DOS CLIENTES
            //var clientes = from cliente in dados.AsEnumerable()
            //               select cliente["nome_cliente"].ToString();
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente);

            //---------OUTRA FOMRA DE PESQUISAR O NOME DOS CLIENTES \/-----------------------------------
            //nomes dos clientes
            //var clientes = (from cliente in dados.AsEnumerable()
            //                select cliente.Field<string>("nome_cliente")).OrderBy(i => i);

            //---------OUTRA FOMRA DE PESQUISAR O NOME DOS CLIENTES \/-----------------------------------
            //var clientes = (
            //               from cliente in dados.AsEnumerable()
            //               select new
            //               {
            //                   nome = cliente.Field<string>("nome_cliente")
            //               }
            //               ).OrderBy(i => i.nome);


            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome);
            #endregion
            //===============================================================================

            #region PESQUISAR O NOME DOS CLIENTES E SUAS ENCOMENDAS
            //var clientes = (from cliente in dados.AsEnumerable()
            //                select new
            //                {
            //                    nome = cliente["nome_cliente"].ToString(),
            //                    numero_encomendas = (int)cliente["numero_encomendas"]
            //                }).OrderByDescending(i => i.numero_encomendas);
            //foreach (var cliente in clientes)
            //    lista.Items.Add(string.Format("O cliente {0} tem {1} encomendas no total.", cliente.nome, cliente.numero_encomendas));
            #endregion
            //===============================================================================

            #region PESQUISAR O NOME DOS CLIENSTE E SUA CIDADE
            //var clientes = from cliente in dados.AsEnumerable()
            //               where cliente.Field<string>("cidade") == "Paris"
            //               select new
            //               {
            //                   nome = cliente["nome_cliente"].ToString(),
            //                   cidade = cliente.Field<string>("cidade")
            //               };
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome + " - " + cliente.cidade);
            #endregion
            //===============================================================================
        }
    }
}