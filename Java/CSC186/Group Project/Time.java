
/**
 * Write a description of class Time here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.*;
public class Time
{
    private String time;
    
    public Time()
    {
        time = null;
    }
    
    public Time(String t)
    {
        time = t;
    }
    
    public String getTime()
    {
        LocalDateTime time = LocalDateTime.now();
        DateTimeFormatter timeFormat = DateTimeFormatter.ofPattern("h:mm a");
        return time.format(timeFormat);
    }
    
    public String getRandomTime()
    {
        LocalDateTime time = LocalDateTime.now();
        Random random = new Random();
        int randomMinutes = random.nextInt(60);
        time = time.plusMinutes(randomMinutes);
        DateTimeFormatter timeFormat = DateTimeFormatter.ofPattern("h:mm a");
        return time.format(timeFormat);
    }
}
