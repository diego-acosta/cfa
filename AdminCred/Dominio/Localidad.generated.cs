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
	public partial class Localidad
	{
		private int _idLocalidad;
		public virtual int IdLocalidad
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
		
		private string _codigoPostal;
		public virtual string CodigoPostal
		{
			get
			{
				return this._codigoPostal;
			}
			set
			{
				this._codigoPostal = value;
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
		
		private int? _idProvincia;
		public virtual int? IdProvincia
		{
			get
			{
				return this._idProvincia;
			}
			set
			{
				this._idProvincia = value;
			}
		}
		
		private Provincium _provincium;
		public virtual Provincium Provincium
		{
			get
			{
				return this._provincium;
			}
			set
			{
				this._provincium = value;
			}
		}
		
		private IList<Persona> _personas = new List<Persona>();
		public virtual IList<Persona> Personas
		{
			get
			{
				return this._personas;
			}
		}
		
		private IList<Persona> _personas1 = new List<Persona>();
		public virtual IList<Persona> Personas1
		{
			get
			{
				return this._personas1;
			}
		}
		
	}
}
#pragma warning restore 1591