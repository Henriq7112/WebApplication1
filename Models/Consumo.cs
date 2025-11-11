using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar a descrição!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar o valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar a quilometragem!")]
        public int Km { get; set; }

        [Display(Name = "Tipo de combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatótio informar o veícullo!")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Alcool
    }
}