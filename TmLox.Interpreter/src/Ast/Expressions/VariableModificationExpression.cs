﻿namespace TmLox.Interpreter.Ast.Expressions
{
    public abstract class VariableModificationExpression : Expression
    {
        public string Variable { get; }

        public Expression Value { get; }


        public VariableModificationExpression(string variable, Expression value)
        {
            Variable = variable;
            Value = value;
        }
    }
}