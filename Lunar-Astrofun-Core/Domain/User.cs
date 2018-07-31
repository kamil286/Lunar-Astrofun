using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lunar.Astrofun.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string UserName { get; protected set; }
        public string FullName { get; protected set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; protected set; }
        public DateTime DateOfBirth { get;  protected set; }
        public DateTime CreatedAt { get; protected set; }
        public IEnumerable<Thumbnail> CreatedThumbanils { get; protected set; }

        protected User() { }

        public User(string email, string username,
            string password, string salt)
        {
            Id = Guid.NewGuid();
            Email = SetEmail(email);
            UserName = username;
            Password = password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        public string SetPassword(string password)
        {
            return IsPasswordValid(password) ? password : throw new FormatException("Bad password format!");
        }

        public string SetEmail(string email)
        {
            return IsMailValid(email) ? email : throw new FormatException("Bad email format!");
        }

        public bool IsPasswordValid(string password)
        {
            bool isPassValid = true;
            if (string.IsNullOrEmpty(password))
                isPassValid = false;

            try
            {
                isPassValid = Regex.IsMatch(password, @"^(.{0,7}|[^0-9]*|[^A-Z])$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

            }
            catch (RegexMatchTimeoutException)
            {
                isPassValid = false;
            }

            return isPassValid;
        }

        private bool IsMailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
                if (email == "")
                    return false;

            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }

        private string DomainMapper(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                return "";
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
