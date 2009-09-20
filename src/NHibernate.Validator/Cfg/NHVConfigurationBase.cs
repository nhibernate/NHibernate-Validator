using System;
using System.Collections.Generic;

namespace NHibernate.Validator.Cfg
{
	public class NHVConfigurationBase : INHVConfiguration
	{
		protected string sharedEngineProviderClass;
		protected readonly IList<MappingConfiguration> mappings = new List<MappingConfiguration>();
		protected readonly IDictionary<string, string> properties = new Dictionary<string, string>();
		protected readonly HashSet<System.Type> entityTypeInspectors = new HashSet<System.Type>();

		public string SharedEngineProviderClass
		{
			get { return sharedEngineProviderClass; }
		}

		/// <summary>
		/// Configured properties
		/// </summary>
		public IDictionary<string, string> Properties
		{
			get { return properties; }
		}

		/// <summary>
		/// Configured Mappings
		/// </summary>
		public IList<MappingConfiguration> Mappings
		{
			get { return mappings; }
		}

		public IEnumerable<System.Type> EntityTypeInspectors
		{
			get { return entityTypeInspectors; }
		}
	}
}