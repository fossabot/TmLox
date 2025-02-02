﻿using System.Collections.Generic;

namespace TmLox.Interpreter.Ast.Statements
{
    public class FunctionDeclarationStatement : Statement
    {
        public string Name { get; }

        public IList<string> Parameters { get; }

        public IList<Statement> Body { get; }


        public FunctionDeclarationStatement(string name, IList<string> parameters, IList<Statement> body)
        {
            Name = name;
            Parameters = parameters;
            Body = body;
        }

        public override T Accept<T>(IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public override NodeType Type()
        {
            return NodeType.FunctionDeclaration;
        }
    }
}
