public static class Bob
{
    public static string Response(string statement)
        => statement switch
        {
            _ when statement == "" 
                || string.IsNullOrWhiteSpace(statement) => "Fine. Be that way!", 
            _ when statement.Trim().EndsWith("?") 
                && statement == statement.ToUpper() 
                && statement.Any(char.IsLetter) => "Calm down, I know what I'm doing!",
            _ when statement.Trim().EndsWith("?")  => "Sure.",
            _ when statement == statement.ToUpper() 
                && statement.Any(char.IsLetter) => "Whoa, chill out!", 
            _ => "Whatever."
        };
}