using ENG8.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8_Infra_Data.EntitiesConfiguration
{
	public class EnderecoConfiguration
	{
		public void Configure(EntityTypeBuilder<Endereco> builder)
		{
			builder.HasKey(e => e.Id);
			builder.HasOne(e => e.Cliente)
				.WithMany(e => e.Enderecos)
				.HasForeignKey(e => e.ClienteId);
		}
	}
}
