﻿using System.Collections.Generic;

namespace TmLox.Ast.Statements
{
    public class WhileStatement : Statement
    {
        public Expression Condition { get; }

        public IList<Statement> Body { get; }


        public WhileStatement(Expression condition)
        {
            Condition = condition;
            Body = new List<Statement>();
        }

        public WhileStatement(Expression condition, IList<Statement> body)
        {
            Condition = condition;
            Body = body;
        }
    }
}
