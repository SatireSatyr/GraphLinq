using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraphLinq.ExpressionTranslator
{
    public class ExpressionVisitor
    {
        public ExpressionVisitor()
        { }

        public string TranslateToGraphQlQuery(Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.Add:
                case ExpressionType.Subtract:
                case ExpressionType.AddChecked:
                case ExpressionType.SubtractChecked:
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                case ExpressionType.Divide:
                case ExpressionType.Modulo:
                    return TranslateBinaryMathematicalExpression(expression as BinaryExpression);

                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                    return TranslateBinaryBooleanExpression(expression as BinaryExpression);

                case ExpressionType.And:
                case ExpressionType.AndAlso:
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                    return TranslateBinaryLogicalExpression(expression as BinaryExpression);

                case ExpressionType.RuntimeVariables:
                case ExpressionType.Constant:
                    return TranslateUnaryConstantExpression(expression as UnaryExpression);

                case ExpressionType.UnaryPlus:
                    return TranslateUnaryMathematicalExpression(expression as UnaryExpression);

                case ExpressionType.Not:
                    return TranslateUnaryBooleanExpression(expression as UnaryExpression);
            }

            throw new NotImplementedException();
        }

        private string TranslateBinaryMathematicalExpression(BinaryExpression expression)
        {
            throw new NotImplementedException();
        }

        private string TranslateBinaryBooleanExpression(BinaryExpression expression)
        {
            throw new NotImplementedException();
        }

        private string TranslateBinaryLogicalExpression(BinaryExpression expression)
        {
            throw new NotImplementedException();
        }

        private string TranslateUnaryConstantExpression(UnaryExpression expression)
        {
            throw new NotImplementedException();
        }

        private string TranslateUnaryMathematicalExpression(UnaryExpression expression)
        {
            throw new NotImplementedException();
        }

        private string TranslateUnaryBooleanExpression(UnaryExpression expression)
        {
            throw new NotImplementedException();
        }
    }
}
