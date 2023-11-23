using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetCafes.Data;
using PetCafes.Models;

    [ApiController]
[Route("[controller]")]

public class ClienteController : ControllerBase
{
    private PetCafeDbContext _context;

    public ClienteController(PetCafeDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Cliente>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        return await _context.Cliente.ToListAsync();
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(string Cpf, string Nome)
    {

        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();

        var cli = new Cliente
        {
            Cpf = Cpf,
            Nome = Nome
        };

        await _context.AddAsync(cli);
        await _context.SaveChangesAsync();
        return Created("", cli);
    }
    [HttpDelete]
    [Route("excluir/{cpf}")]

    public async Task<ActionResult> Excluir(string cpf)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        var cpfTemp = await _context.Cliente.FindAsync(cpf);
        if (cpfTemp is null) return NotFound();
        _context.Remove(cpfTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpPut()]
    [Route("alterar")]
    public async Task<ActionResult> Alterar([FromBody] Cliente cliente)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();

        var clienteExistente = await _context.Cliente.FirstOrDefaultAsync(c => c.Cpf == cliente.Cpf);
        if (clienteExistente == null) return NotFound();

        clienteExistente.Cpf = cliente.Cpf;
        clienteExistente.Nome = cliente.Nome;

        await _context.SaveChangesAsync();

        return Ok();
    }

}
