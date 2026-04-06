using System.Runtime.CompilerServices;
using AutoMapper;
using Zeira.Application.Common.Interfaces;
using Zeira.Application.Common.Models;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace Zeira.Application.UnitTests.Common.Mappings;

public class MappingTests
{
    private ILoggerFactory? _loggerFactory;
    private MapperConfiguration? _configuration;
    private IMapper? _mapper;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        // Minimal logger factory for tests
        _loggerFactory = LoggerFactory.Create(b => b.AddDebug().SetMinimumLevel(LogLevel.Debug));

        _configuration = new MapperConfiguration(cfg =>
            cfg.AddMaps(typeof(IApplicationDbContext).Assembly),
            loggerFactory: _loggerFactory);

        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration!.AssertConfigurationIsValid();
    }



    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        _mapper!.Map(instance, source, destination);
    }

    private static object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        // Type without parameterless constructor
        return RuntimeHelpers.GetUninitializedObject(type);
    }


    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _loggerFactory?.Dispose();
    }
}
