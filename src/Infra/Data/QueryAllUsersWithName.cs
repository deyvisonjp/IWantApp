using Dapper;
using IWantApp.Endpoints.Categories;
using IWantApp.Endpoints.Employees;
using Microsoft.Data.SqlClient;

namespace IWantApp.Infra.Data;
public class QueryAllUsersWithName
{
    private readonly IConfiguration _configuration;
    public QueryAllUsersWithName(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<IEnumerable<EmployeeResponse>> Execute(int page, int rows)
    {
        var db = new SqlConnection(_configuration["ConnectionString:IWantDb"]);
        var query =
            @"SELECT Email, ClaimValue as Name
                FROM AspNetUsers u 
                INNER join AspNetUserClaims c
                ON u.id = c.UserId and ClaimType = 'Name'
                ORDER BY Name
                OFFSET (@page - 1) * @rows ROWS FETCH NEXT @rows ROWS ONLY";
        return await db.QueryAsync<EmployeeResponse>(query, new { page, rows });
    }
}
