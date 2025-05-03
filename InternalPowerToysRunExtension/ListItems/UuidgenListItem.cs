using System;

using Microsoft.CommandPalette.Extensions.Toolkit;

namespace InternalPowerToysRunExtension.ListItems
{
    internal sealed partial class UuidgenListItem : ListItem
    {       
        public UuidgenListItem() :
            base(new NoOpCommand())
        {
            Command = new AnonymousCommand(action: Generate) { Result = CommandResult.KeepOpen() };
            Title = "Increment";
        }

        private void Generate()
        {
            Subtitle = Guid.NewGuid().ToString();
        }
    }
}
