using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PMI_Site.Presentation.ViewComponents
{
    public abstract class BaseViewComponent :ViewComponent
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
