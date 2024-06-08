using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using VueTalk.Application.Categories.Commands.CreateCategory;
using VueTalk.Contracts.Categories;

namespace VueTalk.API.Controllers;

[Route("[controller]")]
public class CategoriesController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _mediator;

    public CategoriesController(IMapper mapper, ISender mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(
        CreateCategoryRequest request)
    {
        var command = _mapper.Map<CreateCategoryCommand>(request);

        var createdCategoryResult = await _mediator.Send(command);

        return createdCategoryResult.Match(
            category => Ok(_mapper.Map<CategoryResponse>(category)),
            errors => Problem(errors));
    }

}

