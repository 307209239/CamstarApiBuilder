// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartHistoryDetail
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
  public class SPCChartHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_FileDirectory")]
    protected Primitive<string> _FileDirectory;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_SPCChartDef")]
    protected NamedObjectRef _SPCChartDef;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_HistoryDetails")]
    protected SubentityRef[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_SPCChartDefName")]
    protected Primitive<string> _SPCChartDefName;

    public override bool Equals(object obj)
    {
      return obj is SPCChartHistoryDetail && object.Equals((object) this._FileName, (object) ((SPCChartHistoryDetail) obj)._FileName) && (object.Equals((object) this._ExportImportKey, (object) ((SPCChartHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._FileDirectory, (object) ((SPCChartHistoryDetail) obj)._FileDirectory)) && (object.Equals((object) this._SPCChartDef, (object) ((SPCChartHistoryDetail) obj)._SPCChartDef) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((SPCChartHistoryDetail) obj)._HistoryDetails) && object.Equals((object) this._SPCChartDefName, (object) ((SPCChartHistoryDetail) obj)._SPCChartDefName)) && base.Equals(obj);
    }

    public Primitive<string> FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileName));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> FileDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileDirectory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileDirectory));
      }
    }

    public NamedObjectRef SPCChartDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDef), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SPCChartDef));
      }
    }

    public SubentityRef[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Primitive<string> SPCChartDefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SPCChartDefName));
      }
    }
  }
}
