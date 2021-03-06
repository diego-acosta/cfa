#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Dominio;

namespace Dominio	
{
	public partial class Cliente
	{
		private int _idCliente;
		public virtual int IdCliente
		{
			get
			{
				return this._idCliente;
			}
			set
			{
				this._idCliente = value;
			}
		}
		
		private int? _idPersona;
		public virtual int? IdPersona
		{
			get
			{
				return this._idPersona;
			}
			set
			{
				this._idPersona = value;
			}
		}
		
		private DateTime? _fechaAlta;
		public virtual DateTime? FechaAlta
		{
			get
			{
				return this._fechaAlta;
			}
			set
			{
				this._fechaAlta = value;
			}
		}
		
		private string _estadoRegistro;
		public virtual string EstadoRegistro
		{
			get
			{
				return this._estadoRegistro;
			}
			set
			{
				this._estadoRegistro = value;
			}
		}
		
		private Persona _persona;
		public virtual Persona Persona
		{
			get
			{
				return this._persona;
			}
			set
			{
				this._persona = value;
			}
		}
		
		private IList<Credito> _creditos = new List<Credito>();
		public virtual IList<Credito> Creditos
		{
			get
			{
				return this._creditos;
			}
		}
		
	}
}
#pragma warning restore 1591
