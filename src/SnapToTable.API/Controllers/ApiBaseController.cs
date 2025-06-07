﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SnapToTable.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiBaseController : ControllerBase
{
    protected readonly ISender Mediator;
    protected ApiBaseController(ISender mediator)
    {
        Mediator = mediator;
    }
}