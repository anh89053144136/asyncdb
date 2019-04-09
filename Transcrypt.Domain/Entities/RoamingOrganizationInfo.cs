using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class RoamingOrganizationInfo
	{
		public Guid OrganizationId { get; set; }

		public int Mode { get; set; }
	}
}