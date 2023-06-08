using EST.MIT.ReferenceData.Api.Interfaces;
using EST.MIT.ReferenceData.Data;
using EST.MIT.ReferenceData.Data.Models;
using EST.MIT.ReferenceData.Data.Models.Codes;
using Microsoft.EntityFrameworkCore;

namespace EST.MIT.ReferenceData.Api.Services.Codes;

/// <summary>
/// Implementation of IReferenceDataService interface using AccountCodes
/// with Entity Framework DbContext
/// </summary>
public class SchemeDataService : IReferenceDataService<SchemeCode>
{
    private readonly ReferenceDataContext _context;

    /// <summary>
    /// Creates instance of SchemeDataService.
    /// </summary>
    /// <param name="context"></param>
    public SchemeDataService(ReferenceDataContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public Task Add(InvoiceRoute route, SchemeCode data)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task AddRange(InvoiceRoute route, IEnumerable<SchemeCode> data)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<SchemeCode>> Get(InvoiceRoute route)
    {
        return await _context.InvoiceRoutes.Where(r => r.RouteId == route.RouteId)
            .Select(r => r.SchemeCodes)
            .SingleAsync();
    }

    /// <inheritdoc />
    public Task Update(InvoiceRoute route, SchemeCode data)
    {
        throw new NotImplementedException();
    }
}
