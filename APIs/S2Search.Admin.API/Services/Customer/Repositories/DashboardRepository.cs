﻿using Domain.Constants;
using Domain.Customer.Constants;
using Domain.Customer.Dashboard;
using Services.Customer.Interfaces.Repositories;
using Services.Dapper.Interfaces.Providers;

namespace Services.Customer.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly IDbContextProvider _dbContext;

        public DashboardRepository(IDbContextProvider dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<DashboardSummaryItem>> GetSummaryItems(Guid customerId, DateTime startDate, DateTime endDate)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "CustomerId", customerId },
                { "StartDate", startDate },
                { "EndDate", endDate }
            };

            var results = await _dbContext.QueryAsync<DashboardSummaryItem>(ConnectionStrings.CustomerResourceStore,
                                                                            StoredProcedures.GetDashboardSummaryForCustomer,
                                                                            parameters);

            return results;
        }
    }
}
