using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Domain.Entities
{
	public class Cliente
	{
		public int Id { get; set; }
		public int IdHtml { get; set; }
		public string CodGuid { get; set; }
		public string CodInterno { get; set; }

		[Required(ErrorMessage = "Cnpj Parametro")]
		[DisplayName("Cnpj Parametro")]
		[StringLength(14)]
		public string CnpjParametro { get; set; }

		[Required(ErrorMessage = "Cnpj Consultado")]
		[DisplayName("Cnpj Consultado")]
		[StringLength(14)]
		public string CnpjConsultado { get; set; }

		[Required(ErrorMessage = "Cnpj")]
		[DisplayName("Cnpj")]
		[StringLength(18)]
		public string CnpjNumInscricao { get; set; }

		[Required(ErrorMessage = "Nome Empresarial")]
		[MinLength(3)]
		[MaxLength(200)]
		[DisplayName("Nome Empresarial")]
		public string NomeEmpresarial { get; set; }

		[MinLength(3)]
		[MaxLength(300)]
		[DisplayName("Nome Fantasia")]
		public string NomeFantasia { get; set; }

		[DisplayName("Data da Importacao")]
		public DateTime DataImportacao { get; set; }

        [DisplayName("Data da Importacao")]
        public DateTime DataAtualizacao { get; set; }

        [Required(ErrorMessage = "Porte da Empresa é obrigatório.")]
		[DisplayName("Porte da Empresa")]
		[StringLength(1)]
		public string PorteEmpresa { get; set; }

		[Required(ErrorMessage = "Valor do Faturamento é obrigatório.")]
		[Column(TypeName = "decimal(18,2)")]
		[DisplayFormat(DataFormatString = "{0:C2}")]
		[DataType(DataType.Currency)]
		[DisplayName("FatBrutoAnual")]
		public decimal FatBrutoAnual { get; set; }

		[DisplayName("Ativo")]
		public bool Ativo { get; set; }
		public ICollection<Endereco> Enderecos { get; set; }

		public DateTime? DataCadastro { get; set; }
	}
}
