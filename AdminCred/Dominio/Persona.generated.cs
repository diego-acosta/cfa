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
	public partial class Persona
	{
		private int _idPersona;
		public virtual int IdPersona
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
		
		private string _dni;
		public virtual string Dni
		{
			get
			{
				return this._dni;
			}
			set
			{
				this._dni = value;
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
		
		private string _direccion;
		public virtual string Direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				this._direccion = value;
			}
		}
		
		private int? _idLocalidad;
		public virtual int? IdLocalidad
		{
			get
			{
				return this._idLocalidad;
			}
			set
			{
				this._idLocalidad = value;
			}
		}
		
		private string _trabajo;
		public virtual string Trabajo
		{
			get
			{
				return this._trabajo;
			}
			set
			{
				this._trabajo = value;
			}
		}
		
		private string _direccionLaboral;
		public virtual string DireccionLaboral
		{
			get
			{
				return this._direccionLaboral;
			}
			set
			{
				this._direccionLaboral = value;
			}
		}
		
		private int? _idlocalidadLaboral;
		public virtual int? IdlocalidadLaboral
		{
			get
			{
				return this._idlocalidadLaboral;
			}
			set
			{
				this._idlocalidadLaboral = value;
			}
		}
		
		private string _email;
		public virtual string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
			}
		}
		
		private decimal? _antiguedad;
		public virtual decimal? Antiguedad
		{
			get
			{
				return this._antiguedad;
			}
			set
			{
				this._antiguedad = value;
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
		
		private Localidad _localidad;
		public virtual Localidad Localidad
		{
			get
			{
				return this._localidad;
			}
			set
			{
				this._localidad = value;
			}
		}
		
		private Localidad _localidad1;
		public virtual Localidad Localidad1
		{
			get
			{
				return this._localidad1;
			}
			set
			{
				this._localidad1 = value;
			}
		}
		
		private IList<TelefonoPersonal> _telefonoPersonals = new List<TelefonoPersonal>();
		public virtual IList<TelefonoPersonal> TelefonoPersonals
		{
			get
			{
				return this._telefonoPersonals;
			}
		}
		
		private IList<TelefonoLaboral> _telefonoLaborals = new List<TelefonoLaboral>();
		public virtual IList<TelefonoLaboral> TelefonoLaborals
		{
			get
			{
				return this._telefonoLaborals;
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
		
		private IList<Solicitud> _solicituds1 = new List<Solicitud>();
		public virtual IList<Solicitud> Solicituds1
		{
			get
			{
				return this._solicituds1;
			}
		}
		
		private IList<Garante> _garantes = new List<Garante>();
		public virtual IList<Garante> Garantes
		{
			get
			{
				return this._garantes;
			}
		}
		
		private IList<Cliente> _clientes = new List<Cliente>();
		public virtual IList<Cliente> Clientes
		{
			get
			{
				return this._clientes;
			}
		}
		
	}
}
#pragma warning restore 1591
