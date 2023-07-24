using System;

namespace Aspose.Email
{
    internal enum GrantTypes
    {
        authorization_code,
        refresh_token
    }

    public class TestUser
    {
        internal TestUser(string name, string eMail, string password, string domain)
        {
            Name = name;
            EMail = eMail;
            Password = password;
            Domain = domain;
        }

        public readonly string Name;
        public readonly string EMail;
        public readonly string Password;
        public readonly string Domain;

        public static bool operator ==(TestUser x, TestUser y)
        {
            if ((object)x != null)
                return x.Equals(y);
            if ((object)y != null)
                return y.Equals(x);
            return true;
        }

        public static bool operator !=(TestUser x, TestUser y)
        {
            return !(x == y);
        }

        public static implicit operator string(TestUser user)
        {
            return user == null ? null : user.Name;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is TestUser && this.ToString().Equals(obj.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Domain) ? Name : string.Format("{0}/{1}", Domain, Name);
        }
    }
    public class GoogleUser : TestUser
    {
        public GoogleUser(string name, string eMail, string password)
            : this(name, eMail, password, null, null, null)
        { }

        public GoogleUser(string name, string eMail, string password, string clientId, string clientSecret)
            : this(name, eMail, password, clientId, clientSecret, null)
        { }

        public GoogleUser(string name, string eMail, string password, string clientId, string clientSecret, string refreshToken)
            : base(name, eMail, password, "gmail.com")
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            RefreshToken = refreshToken;
        }
        public readonly string ClientId;
        public readonly string ClientSecret;
        public readonly string RefreshToken;
    }
}