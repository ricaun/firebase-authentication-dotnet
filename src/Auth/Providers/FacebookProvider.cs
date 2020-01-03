﻿namespace Firebase.Auth.Providers
{
    public class FacebookProvider : OAuthProvider
    {
        public const string DefaultEmailScope = "email";

        public FacebookProvider()
        {
            this.AddScopes(DefaultEmailScope);
        }

        public static AuthCredential GetCredential(string accessToken) => GetCredential(FirebaseProviderType.Facebook, accessToken);

        public override FirebaseProviderType ProviderType => FirebaseProviderType.Facebook;
    }
}
