﻿using System;

namespace XppInterpreter.Parser.Metadata
{
    internal interface ITypeInferExpressionVisitor
    {
        Type VisitContainerInitialisation(ContainerInitialisation containerInitialisation);
        Type VisitConstructor(Constructor constructor);
        Type VisitBinaryOperation(BinaryOperation binaryOperation);
        Type VisitConstant(Constant constant);
        Type VisitTernary(Ternary ternary);
        Type VisitUnaryOperation(UnaryOperation unaryOperation);
        Type VisitVariable(Variable variable);
        Type VisitFunctionCall(FunctionCall functionCall);
        Type VisitIs(Is @is);
        Type VisitAs(As @as);
        Type VisitSelectExpression(SelectExpression selectExpression);
        Type VisitTableField(TableField tableField);
    }
}
