using ListaLeitura.Negocio;
using ListaLeitura.Repositorio;
using Microsoft.AspNetCore.Mvc;


namespace ListaLeitura.Logica
{
    public class CadastroController
    {

        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return "O livro foi adicionado com sucesso";
        }

        public IActionResult ExibeFormulario()
        {
            //var html = HtmlUtils.CarregaArquivoHTML("formulario");
            var html = new ViewResult { ViewName = "formulario" };
            return (IActionResult)html;
        }
    }
}
