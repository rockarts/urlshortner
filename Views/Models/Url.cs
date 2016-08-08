using System;
using System.ComponentModel.DataAnnotations;

public class Url
{
    public int ID { get; set; }

    [Required]
    [Url]
    [Display(Name = "URL")]
    public string LongURL { get; set; }
    public string ShortenedURL
    {
        get; set;
    }

     //Ported from https://www.flickr.com/groups/api/discuss/72157616713786392/
    public string Encode(int num)
    {
        string alphabet = "123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
        int baseCount = alphabet.Length;
        string encoded = "";
        while (num > 0)
        {               
            int remainder = num % baseCount;
            num = Convert.ToInt32(num / baseCount);
            encoded = alphabet[remainder].ToString() + encoded;
        }
        return encoded;
    }

    public int Decode(string stringToDecode)
    {
        string alphabet = "123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
        int decoded = 0;
        int multi = 1;

        while (stringToDecode.Length > 0)
        {
            string digit = stringToDecode.Substring(stringToDecode.Length - 1);
            decoded = decoded + (multi * alphabet.IndexOf(digit));
            multi = multi * alphabet.Length;
            stringToDecode = stringToDecode.Substring(0, stringToDecode.Length - 1);
        }

        return decoded;
    }
}