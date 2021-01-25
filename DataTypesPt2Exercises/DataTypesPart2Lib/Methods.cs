using System;

namespace DataTypesPt2Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class Methods
    {
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            DateTime birthdayCheckDate = new DateTime(date.Year, birthDate.Month, birthDate.Day);
            if (date < birthDate)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }

            if (date > birthdayCheckDate)
            {
                return date.Year - birthDate.Year;
            }
            else
            {
                return date.Year - birthDate.Year - 1;
            }
        }
 
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }
 
        public static string Fortune(Suit suit)
        {
            string output = "";

            switch (suit)
            {
                case (Suit.HEARTS):
                    output = "You've broken my heart";
                    break;
                case (Suit.CLUBS):
                    output = "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case (Suit.DIAMONDS):
                    output = "Diamonds are a girls best friend";
                    break;
                case (Suit.SPADES):
                    output = "Bucket and spade";
                    break;
                default:
                    break;
            }
            
            return output;
        }
    }
}
