using System;
using System.Reflection;

namespace Iprosoft.ELMA.WebApiMail.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}