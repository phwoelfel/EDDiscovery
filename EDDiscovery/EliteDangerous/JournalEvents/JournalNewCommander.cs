﻿
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When written: Creating a new commander
    //Parameters:
    //•	Name: (new) commander name
    //•	Package: selected starter package
    public class JournalNewCommander : JournalEntry
    {
        public JournalNewCommander(JObject evt ) : base(evt, JournalTypeEnum.NewCommander)
        {
            Package = Tools.GetStringDef(evt["Package"]);
        }

        public string Name { get; set; }
        public string Package { get; set; }
    }
}
