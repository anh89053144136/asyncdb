using System;

namespace Transcrypt.Domain.Entities
{
	public class RoamingOrganizationInfo
	{
		public virtual Guid OrganizationId { get; set; }

		public virtual int Mode { get; set; }
	}
}