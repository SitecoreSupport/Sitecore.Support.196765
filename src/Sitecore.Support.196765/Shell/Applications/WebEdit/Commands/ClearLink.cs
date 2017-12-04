namespace Sitecore.Support.Shell.Applications.WebEdit.Commands
{
    using Sitecore.Diagnostics;
    using Sitecore.Shell.Applications.WebEdit.Commands;
    using Sitecore.Shell.Framework.Commands;
    using Sitecore.Web;
    using Sitecore.Web.UI.Sheer;
    public class ClearLink : WebEditLinkCommand
    {
        /// <summary>
        /// Executes the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void Execute(CommandContext context)
        {
            Assert.ArgumentNotNull(context, "context");
            ExplodeParameters(context);
            string formValue = WebUtil.GetFormValue("scPlainValue");
            context.Parameters.Add("fieldValue", formValue);
            Context.ClientPage.Start(this, "Run", context.Parameters);
            
        }
    }
}