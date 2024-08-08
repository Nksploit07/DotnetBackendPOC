using System;
using Microsoft.Extensions.Options;

namespace DotnetBackendPoc;

public class JwtBearerConfigureOptions(IConfiguration configuration) : IConfigureNamedOptions<JwtBearerConfigureOptions>
{
    private const string ConfigurationSectionName = "JwtBearer";
    public void Configure(string? name, JwtBearerConfigureOptions options)
    {
        configuration.GetSection(ConfigurationSectionName).Bind(options);
    }

    public void Configure(JwtBearerConfigureOptions options)
    {
        Configure(options);
    }
}
