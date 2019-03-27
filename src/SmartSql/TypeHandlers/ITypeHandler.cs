﻿using SmartSql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartSql.TypeHandlers
{
    public interface ITypeHandler : IInitialize
    {
        Type MappedType { get; }
        Type FieldType { get; }
        void SetParameter(IDataParameter dataParameter, object parameterValue);
    }
    public interface ITypeHandler<out TProperty, TField> : ITypeHandler
    {
        TProperty Default { get; }
        TProperty GetValue(DataReaderWrapper dataReader, int columnIndex, Type targetType);
    }
}
