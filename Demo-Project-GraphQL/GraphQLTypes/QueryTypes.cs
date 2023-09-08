using Demo_Project_GraphQL.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo_Project_GraphQL.GraphQLTypes
{
    public class QueryTypes
    {
        async Task<List<Cake>> GetAllCakesAsync([Service] MyDbContext context)
        {
            return await context.Cake.ToListAsync();
        }
    }
}
