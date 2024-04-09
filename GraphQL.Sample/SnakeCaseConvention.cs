using HotChocolate.Types.Descriptors;
using Humanizer;
using System.Reflection;

class SnakeCaseConvention : DefaultNamingConventions
{
    public override string GetMemberName(MemberInfo member, MemberKind kind)
    {
        return member.Name.Underscore().ToLower();
    }
}