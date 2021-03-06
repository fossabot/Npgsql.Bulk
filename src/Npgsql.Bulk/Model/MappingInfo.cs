﻿using System.Reflection;
using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Npgsql.Bulk.Model
{
    internal class MappingInfo
    {
        public bool IsInheritanceUsed { get; set; }

        public string TableName { get; set; }

        public string TableNameQualified { get; set; }

        public string TempAliasedColumnName { get; internal set; }

        public string QualifiedColumnName { get; internal set; }

        public PropertyInfo Property { get; set; }

        public MethodInfo OverrideSourceMethod { get; set; }

        public ColumnInfo ColumnInfo { get; set; }

        public NpgsqlDbType NpgsqlType { get; set; }

        public bool IsDbGenerated { get; set; }

        public bool IsKey { get; set; }

        public List<BulkOperationModifierAttribute> ModifierAttributes { get; set; }
    }
}
