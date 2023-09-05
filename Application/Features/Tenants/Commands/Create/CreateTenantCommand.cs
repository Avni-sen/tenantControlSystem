
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Tenants.Commands.Create;
public class CreateTenantCommand : Tenant, IRequest<CreatedTenantResponse>
{
    public class CreateTenantCommandHandler : IRequestHandler<CreateTenantCommand, CreatedTenantResponse>
    {
        private readonly ITenantRepository _tenantRepository;

        public CreateTenantCommandHandler(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public async Task<CreatedTenantResponse>? Handle(CreateTenantCommand request, CancellationToken cancellationToken)
        {
            Tenant newTenant = new();
            newTenant.Id = Guid.NewGuid();
            newTenant.Name = request.Name;

            var result = await _tenantRepository.AddAsync(newTenant);


            CreatedTenantResponse createdTenantResponse = new();

            createdTenantResponse.Id = result.Id;
            createdTenantResponse.Name = result.Name;


            return createdTenantResponse;
        }
    }
}
