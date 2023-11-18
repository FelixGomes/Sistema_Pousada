using System.ComponentModel.DataAnnotations;

namespace sistema_quinta_do_ypua.Models
{
    public class Hospede
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "O nome do hóspede é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Hóspede")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome do hóspede é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Sobrenome do Hóspede")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O telefone do hóspede é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Número de Telefone. ex: (48) 9999-9999")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email do hóspede é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O cpf do hóspede é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "É necessário informar a quantidade de pessoas para realizar a reserva.", AllowEmptyStrings =false)]
        [Display(Name = "Quantidade de pessoas")]
        public int QuantidadePessoas { get; set; }

        // Métodos para atualizar Hóspede e enviar reserva

        public void EnviarReserva()
        {
            //TODO Lógica pra enviar a reserva
        }

        public void AtualizarNomeHospede(String novoNome)
        {
            this.Nome = novoNome;
        }
        public void AtualizarSobrenomeHospede(String novoSobrenome)
        {
            this.Sobrenome = novoSobrenome;
        }
        public void AtualizarTelefone(string novoTelefone)
        {
            if (Telefone != novoTelefone)
            {
                this.Telefone = novoTelefone;
            }
        }

        public void AtualizarCPF(string novoCPF)
        {
            //TODO implementar integração com classe validador de CPF.
            if(Cpf != novoCPF)
            {
                this.Cpf = novoCPF;
            }
        }

        public void AtualizarQuantidadePessoas(int novaQuantidade)
        {
            if(QuantidadePessoas != novaQuantidade && novaQuantidade > 0)
            {
                this.QuantidadePessoas = novaQuantidade;
            }
        }

        public void AtualizarEmail(string novoEmail)
        {
            // TODO Lógica para validar e atualizar o e-mail
            this.Email = novoEmail;
        }
    }
}
