using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public partial record PhoneNumber
{
    private const int DefaultLenghs=9;
    private const string Pattern =@"^(?:-*\d-*){8}$";
    private PhoneNumber(string value) => Value = value;

 public static PhoneNumber? Create(string value)
    {
        if(string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value)||value.Length != DefaultLenghs)
        {
            return null;
        }
        return new PhoneNumber(value);
    } 

    public string Value { get; set; }


 [GeneratedRegex(Pattern)]
 private static partial Regex PhoneNumberRegex();

    public static PhoneNumber Create(object phonenumber)
    {
        throw new NotImplementedException();
    }
}