// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace InternalPowerToysRunExtension;

public partial class InternalPowerToysRunExtensionCommandsProvider : CommandProvider
{
    private readonly ICommandItem[] _commands;

    public InternalPowerToysRunExtensionCommandsProvider()
    {
        DisplayName = "Internal Extension";
        Icon = IconHelpers.FromRelativePath("Assets\\StoreLogo.png");
        _commands = [
            new CommandItem(new InternalPowerToysRunExtensionPage()) { Title = DisplayName },
        ];
    }

    public override ICommandItem[] TopLevelCommands()
    {
        return _commands;
    }

}
