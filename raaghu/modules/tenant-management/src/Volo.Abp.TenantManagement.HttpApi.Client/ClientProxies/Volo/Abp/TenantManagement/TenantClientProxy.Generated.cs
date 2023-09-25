// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.Abp.TenantManagement;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.TenantManagement;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ITenantAppService), typeof(TenantClientProxy))]
public partial class TenantClientProxy : ClientProxyBase<ITenantAppService>, ITenantAppService
{
    public virtual async Task<TenantDto> GetAsync(Guid id)
    {
        return await RequestAsync<TenantDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<PagedResultDto<TenantDto>> GetListAsync(GetTenantsInput input)
    {
        return await RequestAsync<PagedResultDto<TenantDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetTenantsInput), input }
        });
    }

    public virtual async Task<TenantDto> CreateAsync(TenantCreateDto input)
    {
        return await RequestAsync<TenantDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(TenantCreateDto), input }
        });
    }

    public virtual async Task<TenantDto> UpdateAsync(Guid id, TenantUpdateDto input)
    {
        return await RequestAsync<TenantDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(TenantUpdateDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<string> GetDefaultConnectionStringAsync(Guid id)
    {
        return await RequestAsync<string>(nameof(GetDefaultConnectionStringAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task UpdateDefaultConnectionStringAsync(Guid id, string defaultConnectionString)
    {
        await RequestAsync(nameof(UpdateDefaultConnectionStringAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(string), defaultConnectionString }
        });
    }

    public virtual async Task DeleteDefaultConnectionStringAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteDefaultConnectionStringAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}
