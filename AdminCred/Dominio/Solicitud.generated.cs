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
	public partial class Solicitud
	{
		private int _idSolicitud;
		public virtual int IdSolicitud
		{
			get
			{
				return this._idSolicitud;
			}
			set
			{
				this._idSolicitud = value;
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
		
		private int? _idPersonaGarante;
		public virtual int? IdPersonaGarante
		{
			get
			{
				return this._idPersonaGarante;
			}
			set
			{
				this._idPersonaGarante = value;
			}
		}
		
		private int? _idUsuario;
		public virtual int? IdUsuario
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
		
		private Persona _persona1;
		public virtual Persona Persona1
		{
			get
			{
				return this._persona1;
			}
			set
			{
				this._persona1 = value;
			}
		}
		
		private Usuario _usuario;
		public virtual Usuario Usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				this._usuario = value;
			}
		}
		
	}
}
#pragma warning restore 1591