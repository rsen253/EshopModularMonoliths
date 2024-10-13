﻿global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.Diagnostics;
global using Basket.Basket.Dtos;
global using FluentValidation;
global using Mapster;
global using Carter;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Routing;

global using Shared.DDD;
global using Basket.Basket.Models;
global using Basket.Data;
global using Shared.Data.Interceptor;
global using Shared.Data;
global using Shared.CQRS;
global using Shared.Exceptions;
global using Basket.Basket.Exceptions;
global using Basket.Basket.Features.AddItemIntoBasket;
