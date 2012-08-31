using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using Mvc4BootstrapLessDemo.Models;

namespace Mvc4BootstrapLessDemo
{
  public static class AuthConfig
  {
    public static void RegisterAuth()
    {
      // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
      // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

      OAuthWebSecurity.RegisterMicrosoftClient(
        clientId: "enter your Microsoft clientid",
        clientSecret: "enter your Microsoft clientSecret");

      OAuthWebSecurity.RegisterTwitterClient(
        consumerKey: "enter your Twitter consumerKey",
        consumerSecret: "enter your Twitter consumerSecret");

      OAuthWebSecurity.RegisterFacebookClient(
        appId: "enter your Facebook appId",
        appSecret: "enter your Facebook appSecret");

      OAuthWebSecurity.RegisterGoogleClient();
    }
  }
}
