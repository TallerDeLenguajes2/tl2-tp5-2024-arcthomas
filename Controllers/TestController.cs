using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class Test : ControllerBase
{
    [HttpGet("test")]
    public void TestDb()
    {
        PresupuestosRepository test = new PresupuestosRepository();
        test.GetById(2);
    }
}