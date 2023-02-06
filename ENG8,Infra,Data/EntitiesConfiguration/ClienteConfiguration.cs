using ENG8.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8_Infra_Data.EntitiesConfiguration
{
	public class ClienteConfiguration
	{
		public void Configure(EntityTypeBuilder<Cliente> builder) 
		{
			builder.HasKey(e => e.Id);
			builder.Property(e => e.NomeEmpresarial).HasMaxLength(200).IsRequired();
			builder.Property(e => e.NomeFantasia).HasMaxLength(300);
			builder.Property(e => e.PorteEmpresa).HasMaxLength(1).IsRequired();
			builder.Property(e => e.FatBrutoAnual).HasPrecision(10, 2).IsRequired();
			builder.Property(e => e.Ativo).IsRequired();
		}
	}
}
