public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix = number switch
            {
                _ when number % 100 is 11 => "th",
                _ when number % 100 is 12 => "th",
                _ when number % 100 is 13 => "th",
                _ when number % 10 is 1 => "st",
                _ when number % 10 is 2 => "nd",
                _ when number % 10 is 3 => "rd",
                _ => "th"       
            };
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
