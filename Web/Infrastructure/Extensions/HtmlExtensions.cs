using System.Web;
using System.Web.Mvc;

namespace Mvc4BootstrapLessDemo
{
  public static class HtmlExtensions
  {
    public static IHtmlString AuthButton(this HtmlHelper htmlHelper, string providerName, string displayName)
    {
      //<button type="submit" class="btn" name="provider" value="@p.AuthenticationClient.ProviderName" title="Log in using your @p.DisplayName account"><i class="icon-google"></i> @p.DisplayName</button>
      var button = new TagBuilder("button");
      button.AddCssClass("btn");
      button.Attributes.Add("type", "submit");
      button.Attributes.Add("name", "provider");
      button.Attributes.Add("value", providerName);
      button.Attributes.Add("title", string.Format("Log in using your {0} account", displayName));

      var text = "";
      const string textPlaceholder = "<i class=\"{0}\"></i> {1}";
      switch(providerName)
      {
        case "google":
          text = string.Format(textPlaceholder, "icon-google", displayName);
          break;
        case "facebook":
          text = string.Format(textPlaceholder, "icon-facebook", displayName);
          break;
        case "twitter":
          text = string.Format(textPlaceholder, "icon-twitter", displayName);
          break;
        case "microsoft":
          text = string.Format(textPlaceholder, "icon-microsoft", displayName);
          break;
        default:
          text = "";
          break;
      }

      button.InnerHtml = text;

      return new HtmlString(button.ToString(TagRenderMode.Normal));
    }
  }
}