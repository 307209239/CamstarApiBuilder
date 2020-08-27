// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportTxns
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
  public class ExportImportTxns : Update
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_ExportImportType")]
    protected Enumeration<ExportImportTypeEnum, int> _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Details")]
    protected ExportImportItem[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_ExportImportName")]
    protected Primitive<string> _ExportImportName;

    public override bool Equals(object obj)
    {
      return obj is ExportImportTxns && object.Equals((object) this._ExportImportType, (object) ((ExportImportTxns) obj)._ExportImportType) && (this.CompareArrays((Array) this._Details, (Array) ((ExportImportTxns) obj)._Details) && object.Equals((object) this._ExportImportName, (object) ((ExportImportTxns) obj)._ExportImportName)) && base.Equals(obj);
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

    public ExportImportItem[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ExportImportItem[]) this.PropertyGet(nameof (Details));
      }
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
  }
}
