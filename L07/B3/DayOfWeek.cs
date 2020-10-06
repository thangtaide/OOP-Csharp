using System;
class DayOfWeek
{
    public string Days(string value)
    {
        if(value.ToLower().Equals("monday")) return "Monday: 1";
        else if(value.ToLower().Equals("tuesday")) return "tuesday: 2";
        else if(value.ToLower().Equals("wenesday")) return "Wenesday: 3";
        else if(value.ToLower().Equals("thusday")) return "Thusday: 4";
        else if(value.ToLower().Equals("friday")) return "Friday: 5";
        else if(value.ToLower().Equals("saturday")) return "Saturday: 6";
        else if(value.ToLower().Equals("sunday")) return "Sunday: 0";
        else return "No day of week";
    }

}