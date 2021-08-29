using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args); 
    //C# convention is the first element pathed to Delegate identifies the sender of event
    // teh second element is a set of event arguments
}