using System;

// Class representing a CallNumber object, which combines a numerical part and author initials.
public class CallNumber
{
    // Property to store the numerical part of the call number.
    public string Number { get; set; }

    // Property to store the author's initials.
    public string AuthorInitials { get; set; }

    // Property that returns the full call number by combining Number and AuthorInitials.
    public string FullCallNumber
    {
        get { return $"{Number} {AuthorInitials}"; }
    }
}

