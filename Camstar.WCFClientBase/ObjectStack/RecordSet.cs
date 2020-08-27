// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSet
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Data;
using System.Globalization;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RecordSet
  {
    [DataMember(EmitDefaultValue = false)]
    public Header[] Headers { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public Row[] Rows { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int TotalCount { get; set; }

    public DataTable GetAsDataTable()
    {
      return this.GetAsDataTable(false, false);
    }

    public DataTable GetAsDataTable(bool getDefault, bool isExplicit)
    {
      DataTable dataTable = (DataTable) null;
      if (this.Headers != null)
      {
        dataTable = new DataTable(nameof (RecordSet));
        foreach (Header header in this.Headers)
        {
          DataColumn column = new DataColumn();
          if (header != null)
          {
            if (header.Label != null)
              column.Caption = getDefault ? header.Label.DefaultValue : header.Label.Value;
            column.ColumnName = header.Name;
            if (isExplicit)
              column.DataType = this.ToDataType(header.TypeCode);
          }
          dataTable.Columns.Add(column);
        }
        if (this.Rows != null)
        {
          foreach (Row row1 in this.Rows)
          {
            if (row1 != null)
            {
              DataRow row2 = dataTable.NewRow();
              int index = 0;
              if (row1.Values != null)
              {
                foreach (string str in row1.Values)
                {
                  row2[index] = !string.IsNullOrEmpty(str) ? (isExplicit ? Convert.ChangeType((object) str, dataTable.Columns[index].DataType, (IFormatProvider) CultureInfo.InvariantCulture) : (object) str) : (object) DBNull.Value;
                  ++index;
                }
              }
              dataTable.Rows.Add(row2);
            }
          }
        }
      }
      return dataTable;
    }

    public DataTable GetAsExplicitlyDataTable()
    {
      return this.GetAsDataTable(false, true);
    }

    public Type ToDataType(TypeCode typeCode)
    {
      Type type = typeof (string);
      switch (typeCode)
      {
        case TypeCode.Boolean:
          type = typeof (bool);
          break;
        case TypeCode.Int32:
          type = typeof (int);
          break;
        case TypeCode.Double:
          type = typeof (double);
          break;
        case TypeCode.Decimal:
          type = typeof (Decimal);
          break;
        case TypeCode.DateTime:
          type = typeof (DateTime);
          break;
      }
      return type;
    }
  }
}
