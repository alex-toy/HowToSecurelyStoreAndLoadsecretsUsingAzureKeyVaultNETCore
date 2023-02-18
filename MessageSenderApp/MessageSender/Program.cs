using Azure.Core;
using Azure.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.KeyVault;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using Microsoft.Extensions.Hosting;

namespace MessageSender
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureAppConfiguration((context, config) =>
                {
                    IConfigurationRoot builtConfig = config.Build();
                    string vaultName = builtConfig["keyVault"];
                    KeyVaultClient keyVaultClient = new KeyVaultClient(async (authority, resource, scope) =>
                    {
                        DefaultAzureCredential credential = new DefaultAzureCredential(false);
                        AccessToken token = credential.GetToken(new TokenRequestContext(new[] { "https://vault.azure.net/.default" }));
                        return token.Token;
                    });
                    config.AddAzureKeyVault(vaultName, keyVaultClient, new DefaultKeyVaultSecretManager());
                });
    }
}
