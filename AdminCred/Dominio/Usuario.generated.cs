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
	public partial class Usuario
	{
		private int _idUsuario;
		public virtual int IdUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				this._idUsuario = value;
			}
		}
		
		private string _nombreUsuario;
		public virtual string NombreUsuario
		{
			get
			{
				return this._nombreUsuario;
			}
			set
			{
				this._nombreUsuario = value;
			}
		}
		
		private string _password;
		public virtual string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
		
		private string _nombre;
		public virtual string Nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				this._nombre = value;
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
		
		private IList<Solicitud> _solicituds = new List<Solicitud>();
		public virtual IList<Solicitud> Solicituds
		{
			get
			{
				return this._solicituds;
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
