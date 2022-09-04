using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypescriptNet.Sandbox
{
    internal class Models
    {
    }

    public class Class1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Statement[] Statements { get; set; }
        public Endoffiletoken endOfFileToken { get; set; }
        public string fileName { get; set; }
        public string text { get; set; }
        public int languageVersion { get; set; }
        public int languageVariant { get; set; }
        public int scriptKind { get; set; }
        public bool isDeclarationFile { get; set; }
        public bool hasNoDefaultLib { get; set; }
        public object[] bindDiagnostics { get; set; }
        public Externalmoduleindicator externalModuleIndicator { get; set; }
        public Pragmas pragmas { get; set; }
        public object[] referencedFiles { get; set; }
        public object[] typeReferenceDirectives { get; set; }
        public object[] libReferenceDirectives { get; set; }
        public object[] amdDependencies { get; set; }
        public int nodeCount { get; set; }
        public int identifierCount { get; set; }
        public Identifiers identifiers { get; set; }
        public object[] parseDiagnostics { get; set; }
        public string jstype { get; set; }
    }

    public class Endoffiletoken
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Externalmoduleindicator
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Name name { get; set; }
        public Modifier[] modifiers { get; set; }
        public Member[] members { get; set; }
        public string jstype { get; set; }
        public Importclause importClause { get; set; }
        public Modulespecifier moduleSpecifier { get; set; }
    }

    public class Name
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Importclause
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public bool isTypeOnly { get; set; }
        public Namedbindings namedBindings { get; set; }
        public string jstype { get; set; }
    }

    public class Namedbindings
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Element[] elements { get; set; }
        public string jstype { get; set; }
    }

    public class Element
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public bool isTypeOnly { get; set; }
        public Name1 name { get; set; }
        public string jstype { get; set; }
    }

    public class Name1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Modulespecifier
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string text { get; set; }
        public bool hasExtendedUnicodeEscape { get; set; }
        public string jstype { get; set; }
    }

    public class Modifier
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Member
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Name2 name { get; set; }
        public Type type { get; set; }
        public Questiontoken questionToken { get; set; }
        public string jstype { get; set; }
        public Modifier1[] modifiers { get; set; }
    }

    public class Name2
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Type
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Questiontoken
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Modifier1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Pragmas
    {
        public string jstype { get; set; }
    }

    public class Identifiers
    {
        public string jstype { get; set; }
    }

    public class Statement
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Name3 name { get; set; }
        public Modifier2[] modifiers { get; set; }
        public Member1[] members { get; set; }
        public string jstype { get; set; }
        public Importclause1 importClause { get; set; }
        public Modulespecifier1 moduleSpecifier { get; set; }
    }

    public class Name3
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Importclause1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public bool isTypeOnly { get; set; }
        public Namedbindings1 namedBindings { get; set; }
        public string jstype { get; set; }
    }

    public class Namedbindings1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Element1[] elements { get; set; }
        public string jstype { get; set; }
    }

    public class Element1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public bool isTypeOnly { get; set; }
        public Name4 name { get; set; }
        public string jstype { get; set; }
    }

    public class Name4
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Modulespecifier1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string text { get; set; }
        public bool hasExtendedUnicodeEscape { get; set; }
        public string jstype { get; set; }
    }

    public class Modifier2
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Member1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public Name5 name { get; set; }
        public Type1 type { get; set; }
        public Questiontoken1 questionToken { get; set; }
        public string jstype { get; set; }
        public Modifier3[] modifiers { get; set; }
    }

    public class Name5
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Type1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
        public Typename typeName { get; set; }
    }

    public class Typename
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string escapedText { get; set; }
        public string jstype { get; set; }
    }

    public class Questiontoken1
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

    public class Modifier3
    {
        public int pos { get; set; }
        public int end { get; set; }
        public int flags { get; set; }
        public int modifierFlagsCache { get; set; }
        public int transformFlags { get; set; }
        public int kind { get; set; }
        public string jstype { get; set; }
    }

}
