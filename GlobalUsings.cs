global using API.ComponentModels.DataAnnotations.Requests;

global using API.Persistance;

global using API.Repository;

global using Asp.Versioning;

global using Microsoft.AspNetCore.Authorization;

global using Microsoft.AspNetCore.Mvc;

global using Microsoft.EntityFrameworkCore;

global using Microsoft.EntityFrameworkCore.Migrations;
global using Muonroi.BuildingBlock.External;

global using Muonroi.BuildingBlock.External.Common;

global using Muonroi.BuildingBlock.External.Common.Constants;

global using Muonroi.BuildingBlock.External.Controller;

global using Muonroi.BuildingBlock.External.Cors;

global using Muonroi.BuildingBlock.External.Default;

global using Muonroi.BuildingBlock.External.DI;

global using Muonroi.BuildingBlock.External.Entity;

global using Muonroi.BuildingBlock.External.Entity.DataSample;

global using Muonroi.BuildingBlock.External.Entity.Identity;

global using Muonroi.BuildingBlock.External.Helper;

global using Muonroi.BuildingBlock.External.Interfaces;

global using Muonroi.BuildingBlock.External.Logging;

global using Muonroi.BuildingBlock.External.Models;

global using Muonroi.BuildingBlock.External.Response;

global using Muonroi.BuildingBlock.External.SeedWorks;

global using Serilog;

global using System.Reflection;

global using ILogger = Serilog.ILogger;global using MediatR;
global using Muonroi.BuildingBlock.External.BearerToken;
global using Microsoft.Extensions.Caching.Distributed;
global using Muonroi.BuildingBlock.External.Caching.Distributed.Redis;
