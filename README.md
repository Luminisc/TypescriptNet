# `Typescript Objects To Cs` converter

### What
Creating Typescript to AST parser, to work with TS AST in similar way as people doing it in Roslyn analyzers. 
(and reuse Roslyns types and logic as much as possible)

### Why
Want to parse TS files with plain classes/interfaces with data to C# classes (or plain JSON for data + C# classes for models)

### Project structure
- CodeAnalysisSandbox - used as sandbox to understand how Roslyn works from perspective of how to create workspace, load files, generate AST, how to work with AST (and what user can do)
- TypescriptNet - this is project to store classes/enums/logic from `typescript` library. Trying to preserve structure of models and namespace.
- TypescriptNet.Sandbox - currently main sandbox project to test libraries, ideas, etc.