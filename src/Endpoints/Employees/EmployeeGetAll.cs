using Microsoft.AspNetCore.Identity;

namespace IWantApp.Endpoints.Employees;

public class EmployeeGetAll
{
    public static string Template => "/employees";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    //Realizando um GetAll por paginação
    public static IResult Action(int page, int rows, UserManager<IdentityUser> userManager)
    {
        var users = userManager.Users.Skip((page - 1) * rows).Take(rows).ToList(); //Percorre a cada 'x' linhas
        var employees = new List<EmployeeResponse>();
        foreach (var item in users)
        {
            var claims = userManager.GetClaimsAsync(item).Result;
            var claimName = claims.FirstOrDefault(c => c.Type == "Name");
            var userName = claimName != null ? claimName.Value : string.Empty;
            employees.Add(new EmployeeResponse(item.Email, userName));
        }
        return Results.Ok(employees);
    }

    //public static IResult Action(UserManager<IdentityUser> userManager)
    //{
    //    var users = userManager.Users.ToList();
    //    var employees = new List<EmployeeResponse>();
    //    foreach (var item in users)
    //    {
    //        var claims = userManager.GetClaimsAsync(item).Result;
    //        var claimName = claims.FirstOrDefault(c => c.Type == "Name");
    //        var userName = claimName != null ? claimName.Value : string.Empty;
    //        employees.Add(new EmployeeResponse(item.Email, userName));
    //    }
    //    return Results.Ok(employees);
    //}
}
