﻿using Domain.Constants;
using Domain.Customer.Constants;
using Domain.SearchResources;
using S2Search.Common.Database.Sql.Dapper.Interfaces.Providers;
using Services.Configuration.Interfaces.Repositories;

namespace Services.Configuration.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        private readonly IDbContextProvider _dbContext;

        public ThemeRepository(IDbContextProvider dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Theme> GetThemeAsync(string customerEndpoint)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "CustomerEndpoint", customerEndpoint }
            };

            var result = await _dbContext.QuerySingleOrDefaultAsync<Theme>(ConnectionStrings.CustomerResourceStore,
                                                                           StoredProcedures.GetTheme,
                                                                           parameters);

            return result;
        }
    }
}