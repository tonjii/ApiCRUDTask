using System.ComponentModel.DataAnnotations;

namespace MVCTask.Models
{
    public class ContatoModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o seu Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Digite a Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Insira a Data")]
        public string Data { get; set; }

        [Required(ErrorMessage = "Informe o começo da Tarefa")]
        public string Inicio { get; set; }

        [Required(ErrorMessage = "Informe o fim da Tarefa")]
        public string Fim { get; set; }

        [Required(ErrorMessage = "Informe o nível de prioriedade da Tarefa")]
        public string Prioridade { get; set; }

        [Required(ErrorMessage = "Informe se foi Finalizado")]
        public string Finalizado { get; set; }



      
    }
}
