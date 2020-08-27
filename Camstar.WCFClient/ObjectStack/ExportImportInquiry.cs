// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportInquiry
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ExportImportInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_ExportImportName")]
    protected Primitive<string> _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_StatusDetails")]
    protected ExportImportStatus _StatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_ExportImportType")]
    protected Enumeration<ExportImportTypeEnum, int> _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_LogStartRow")]
    protected Primitive<int> _LogStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_IncludeLog")]
    protected Primitive<bool> _IncludeLog;

    public override bool Equals(object obj)
    {
      return obj is ExportImportInquiry && object.Equals((object) this._ExportImportName, (object) ((ExportImportInquiry) obj)._ExportImportName) && (object.Equals((object) this._StatusDetails, (object) ((ExportImportInquiry) obj)._StatusDetails) && object.Equals((object) this._ExportImportType, (object) ((ExportImportInquiry) obj)._ExportImportType)) && (object.Equals((object) this._LogStartRow, (object) ((ExportImportInquiry) obj)._LogStartRow) && object.Equals((object) this._IncludeLog, (object) ((ExportImportInquiry) obj)._IncludeLog)) && base.Equals(obj);
    }

    public Primitive<string> ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public ExportImportStatus StatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusDetails), (object) value);
      }
      get
      {
        return (ExportImportStatus) this.PropertyGet(nameof (StatusDetails));
      }
    }

    public Enumeration<ExportImportTypeEnum, int> ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportTypeEnum, int>) this.PropertyGet(nameof (ExportImportType));
      }
    }

    public Primitive<int> LogStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogStartRow), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LogStartRow));
      }
    }

    public Primitive<bool> IncludeLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeLog), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeLog));
      }
    }
  }
}
