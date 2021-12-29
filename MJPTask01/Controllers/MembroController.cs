using MJPTask01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJPTask01.Controllers
{
    public class MembroController : Controller
    {

        static List<Membro> membros = new List<Membro>();
        
        public ActionResult Index()
        {
            
            return View(membros);
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
           

            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Membro membro)
        {
            if (ModelState.IsValid)
            {
                
                membros.Add(membro);
            }
            
            return View("Index", membros);
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            var membro = membros.Find(m => m.id == id);

            return View(membro);
        }
        [HttpPost]
        public ActionResult Editar(Membro membro)
        {
            if (ModelState.IsValid)
            {
                
                var membroAtual = membros.FirstOrDefault(m => m.id == membro.id);
                if (!membroAtual.Equals(membro))
                {
                    membroAtual.NomeCompleto = membro.NomeCompleto;
                    membroAtual.DataNacimento = membro.DataNacimento;
                    membroAtual.DataBatismo = membro.DataBatismo;
                    membroAtual.ContatoPessoal.Email = membro.ContatoPessoal.Email;
                    membroAtual.ContatoPessoal.NumeroCelular = membro.ContatoPessoal.NumeroCelular;
                    membroAtual.Endereco.Cep = membro.Endereco.Cep;
                    membroAtual.Endereco.Rua = membro.Endereco.Rua;
                    membroAtual.Endereco.NumeroCasa = membro.Endereco.NumeroCasa;
                    membroAtual.Endereco.Bairro = membro.Endereco.Bairro;
                    membroAtual.Endereco.Cidade = membro.Endereco.Cidade;
                    membroAtual.Endereco.Estado = membro.Endereco.Estado;

                }
            }

            return View("Index", membros);
        }

       
        public ActionResult Excluir(Guid id)
        {
            var membro = membros.FirstOrDefault(m => m.id == id);
            membros.Remove(membro);
            return View("Index", membros);
        }

    }
    
}