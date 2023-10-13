﻿using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistance.Repositories
{
	public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
	{
		public UserOperationClaimRepository(BaseDbContext context) : base(context)
		{
		}
	}
}
