using System;

namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.Api20180214
{
    public partial class Vault
    {
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.FormatTable(Index = 1)]
        public string ResourceGroupName
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Id))
                {
                    string[] tokens = this.Id.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    if (tokens.Length < 8)
                    {
                        return string.Empty;
                    }

                    for (int i = 0; i < tokens.Length - 1; i++)
                    {
                        if (tokens[i].Equals("resourceGroups"))
                        {
                            return tokens[i + 1];
                        }
                    }
                }

                return string.Empty;
            }
        }
    }
}