using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentOrganizer.domain
{
    public enum PlayerStrength : int
	{
        // TODO : Currently the Strings are directly displayed in the view. It would be better to have a DisplayString Attribute.
        Beginner = 1, Intermediate = 2, Advanced = 3, Professional = 4
	} 
}
