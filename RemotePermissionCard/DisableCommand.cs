﻿using Smod2;
using Smod2.Commands;

namespace RemotePermissionCard
{
    internal class DisableCommand : ICommandHandler
    {
        private RemotePermissionCard plugin;
        public DisableCommand(RemotePermissionCard plugin) => this.plugin = plugin;

        public string GetCommandDescription()
        {
            return "Disable this pluign";
        }

        public string GetUsage()
        {
            return "rpc_disable";
        }

        public string[] OnCall(ICommandSender sender, string[] args)
        {
            /*
            if (sender is Smod2.API.Player p)
            {
                if (!p.HasPermission("remotepermissioncard.disable"))
                {
                    return new string[] { "You don't have permission to use that command." };
                }
            }
            */

            PluginManager.Manager.DisablePlugin(plugin);
            return new string[] { "RemotePermissionCard disabled. " };
        }
    }
}