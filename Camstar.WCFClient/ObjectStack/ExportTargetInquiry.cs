// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportTargetInquiry
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
  public class ExportTargetInquiry : ExportImportInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_ExportImportName")]
    protected new Primitive<string> _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_ExportImportType")]
    protected new Enumeration<ExportImportTypeEnum, int> _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_ExportTargetDetails")]
    protected ExportTargetDetail[] _ExportTargetDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_NumberOfRows")]
    protected Primitive<int> _NumberOfRows;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_StartRow")]
    protected Primitive<int> _StartRow;

    public override bool Equals(object obj)
    {
      return obj is ExportTargetInquiry && object.Equals((object) this._ExportImportName, (object) ((ExportTargetInquiry) obj)._ExportImportName) && (object.Equals((object) this._ExportImportType, (object) ((ExportTargetInquiry) obj)._ExportImportType) && this.CompareArrays((Array) this._ExportTargetDetails, (Array) ((ExportTargetInquiry) obj)._ExportTargetDetails)) && (object.Equals((object) this._NumberOfRows, (object) ((ExportTargetInquiry) obj)._NumberOfRows) && object.Equals((object) this._StartRow, (object) ((ExportTargetInquiry) obj)._StartRow)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportName
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

    public new Enumeration<ExportImportTypeEnum, int> ExportImportType
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

    public ExportTargetDetail[] ExportTargetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetDetails), (object) value);
      }
      get
      {
        return (ExportTargetDetail[]) this.PropertyGet(nameof (ExportTargetDetails));
      }
    }

    public Primitive<int> NumberOfRows
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberOfRows), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NumberOfRows));
      }
    }

    public Primitive<int> StartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartRow), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (StartRow));
      }
    }
  }
}
