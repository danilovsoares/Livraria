using Livraria.Application.Livro.Services.Interfaces;
using Livraria.Application.Livros.ViewModels.Request;
using Livraria.Domain.Core.Bus;
using Livraria.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Livraria.WebApi.Controllers
{
    public class LivroController : ApiController
    {
        private readonly ILivroAppService _LivroAppService;

        public LivroController(
            ILivroAppService livroAppService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator) : base(notifications, mediator)
        {
            _LivroAppService = livroAppService;
        }

        [HttpGet]
        [Route("livro")]
        public IActionResult Get()
        {
            return Response(_LivroAppService.GetAll());
        }

        [HttpGet]
        [Route("livro/{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var livro = _LivroAppService.GetById(id);
            return Response(livro);
        }

        [HttpPost]
        [Route("livro/novo")]
        public IActionResult Post([FromBody]SalvarLivroViewModel livro)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(livro);
            }

            _LivroAppService.Save(livro);
            return Response(livro);
        }

        [HttpPut]
        [Route("livro/atualizar")]
        public IActionResult Put([FromBody]AtualizarLivroViewModel livro)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(livro);
            }

            _LivroAppService.Update(livro);
            return Response(livro);
        }

        [HttpDelete]
        [Route("livro/deletar/{id:Guid}")]
        public IActionResult Delete(Guid id)
        {
            _LivroAppService.Remove(id);
            return Response();
        }
    }
}