using System;

namespace Exercicio_1
{
    public class Cliente
    {
        private readonly Logger _logger;
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            _logger = Logger.GetLogger();
            Nome = nome;
        }
        
        public void AtualizaEndereco(string endereco, string cidade)
        {
            // Salva os dados no banco de dados

            // Registra no log a alteração do endereço
            _logger.Registrar($"\nEndereço atualizado para o cliente {Nome} em {DateTime.Now}");
        }
    }
}
