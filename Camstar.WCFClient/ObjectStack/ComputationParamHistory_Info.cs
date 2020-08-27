// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamHistory_Info
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
  public class ComputationParamHistory_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Info_ParamValue")]
    protected Info _ParamValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Info_ParamName")]
    protected Info _ParamName;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public Info ParamValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParamValue));
      }
    }

    public Info ParamName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParamName));
      }
    }
  }
}
