using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;

namespace linq
{
    //==================================================
    public class cl_alunos
    {
        //==============================================
        public class cl_exames
        {
            public string disciplina { get; set; }
            public int nota_exame { get; set; }
        }

        public int numero { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public List<cl_exames> EXAMES { get; set; }
    }

    //==================================================
    public class cl_colecoes
    {
        public List<int> lista_numeros { get; set; }
        public List<string> lista_nomes { get; set; }
        public Dictionary<string, double> lista_produtos { get; set; }//o dictionary tem 2 valores KEY = string / VALUE = DOUBLE
        public List<cl_alunos> lista_alunos { get; set; }
        public DataTable dados { get; set; }

        //----------------------------------------------
        public cl_colecoes()
        {
            //------------------------------------------
            #region LISTA_NUMEROS
            lista_numeros = new List<int>()
            { 14, 16, 8, 13, 3, 15, 9, 12, 45, 34, 23, 56, 32, 11, 43};
            #endregion

            //------------------------------------------
            #region LISTA_NOMES
            lista_nomes = new List<string>()
            { "João Ribeiro", "Carla Marques", "Paulo Silva", "Franciso Matos",
              "Anabela Santos", "Carolina Soares", "Marta Silva", "Ricardo Almeida",
              "Tiago Silva", "Paulo Fonseca"};
            #endregion

            //------------------------------------------
            #region LISTA_PRODUTOS
            lista_produtos = new Dictionary<string, double>()
            {
                { "Laranja", 12.5 },
                { "Maçã", 8.7},
                { "Ananás", 17.2},
                { "Maracujá", 4.6},
                { "Banana", 2.8},
                { "Pão", 1.2},
                { "Sorvete", 8},
                { "Refrigerante", 18.5},
                { "Queijo", 32.2},
                { "Arroz", 12.4}
            };
            #endregion

            //------------------------------------------
            #region LISTA_ALUNOS
            lista_alunos = new List<cl_alunos>();
            cl_alunos aluno;

            //aluno 1
            aluno = new cl_alunos();
            aluno.numero = 1;
            aluno.nome = "Ana Carolina";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 12},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 14},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 9 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 11}
            };
            lista_alunos.Add(aluno);

            //aluno 2
            aluno = new cl_alunos();
            aluno.numero = 2;
            aluno.nome = "Bernardo José";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 16},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 15},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 17 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 18}
            };
            lista_alunos.Add(aluno);

            //aluno 3
            aluno = new cl_alunos();
            aluno.numero = 3;
            aluno.nome = "Cristina Marques";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 8},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 11},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 10 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 7}
            };
            lista_alunos.Add(aluno);

            //aluno 4
            aluno = new cl_alunos();
            aluno.numero = 4;
            aluno.nome = "Fernando Castro";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 13},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 15},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 12 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 13}
            };
            lista_alunos.Add(aluno);

            //aluno 5
            aluno = new cl_alunos();
            aluno.numero = 5;
            aluno.nome = "Helena Cristina";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 18},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 17},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 18 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 20}
            };
            lista_alunos.Add(aluno);

            //aluno 6
            aluno = new cl_alunos();
            aluno.numero = 6;
            aluno.nome = "Luis Miguel";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 11},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 12},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 10 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 11}
            };
            lista_alunos.Add(aluno);

            //aluno 7
            aluno = new cl_alunos();
            aluno.numero = 7;
            aluno.nome = "Márcia Correia";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 16},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 15},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 17 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 12}
            };
            lista_alunos.Add(aluno);

            //aluno 8
            aluno = new cl_alunos();
            aluno.numero = 8;
            aluno.nome = "Rogério Fernandes";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 8},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 9},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 9 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 7}
            };
            lista_alunos.Add(aluno);

            //aluno 9
            aluno = new cl_alunos();
            aluno.numero = 9;
            aluno.nome = "Susana Martins";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 13},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 13},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 16 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 14}
            };
            lista_alunos.Add(aluno);

            //aluno 10
            aluno = new cl_alunos();
            aluno.numero = 2;
            aluno.nome = "Tomé Costa";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 18},
                new cl_alunos.cl_exames() { disciplina = "Inglês", nota_exame = 19},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 19 },
                new cl_alunos.cl_exames() { disciplina = "Laboratório", nota_exame = 17}
            };
            lista_alunos.Add(aluno);
            #endregion

            //------------------------------------------
            #region DATATABLE
            //estrutura da datatable
            //quanto mais rapido entrar na base de dados e sair dela melhor ! (nunca fique muito tempo na base de dados)
            dados = new DataTable();
            dados.Columns.Add("id_cliente", typeof(int)); //[0]
            dados.Columns.Add("nome_cliente", typeof(string)); //[1]
            dados.Columns.Add("cidade", typeof(string)); //[2]
            dados.Columns.Add("numero_encomendas", typeof(int)); //[3]

            //carrega os dados de todos os clientes
            StreamReader file = new StreamReader(Environment.CurrentDirectory + @"\dados.txt", Encoding.Default); //o dados.txt esta aqui "C:\csharp\linq\linq\bin\Debug"
            while (!file.EndOfStream)
            {
                DataRow linha = dados.NewRow();
                linha["id_cliente"] = int.Parse(file.ReadLine());
                linha["nome_cliente"] = file.ReadLine();
                linha["cidade"] = file.ReadLine();
                linha["numero_encomendas"] = int.Parse(file.ReadLine());
                dados.Rows.Add(linha);
            }
            file.Dispose();
            #endregion
        }
    }
}