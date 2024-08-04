using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD
{
    static class ConexaoBancoDDados
    {

        private const string servidor = "localhost";
        private const string bancoDados = "dbAlunos";
        private const string usuario = "root";
        private const string senha = "Kaka123@";
        static public string bancoServidor = $"Server={servidor}; User ID={usuario}; " +
            $"Database={bancoDados}; Password={senha};";

    }
}
