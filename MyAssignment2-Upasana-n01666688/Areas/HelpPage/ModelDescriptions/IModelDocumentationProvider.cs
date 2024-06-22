using System;
using System.Reflection;

namespace MyAssignment2_Upasana_n01666688.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}