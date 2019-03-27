﻿using SmartSql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartSql.TypeHandlers
{
    public class SByteTypeHandler : AbstractNullableTypeHandler<SByte, SByte>
    {
        public override SByte GetValue(DataReaderWrapper dataReader, int columnIndex, Type targetType)
        {
            return dataReader.GetFieldValue<SByte>(columnIndex);
        }
    }
    public class SByteAnyTypeHandler : AbstractNullableTypeHandler<SByte, AnyFieldType>
    {
        public override SByte GetValue(DataReaderWrapper dataReader, int columnIndex, Type targetType)
        {
            return Convert.ToSByte(dataReader.GetValue(columnIndex));
        }
    }
}
