// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamDetail_Info
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
  public class ComputationParamDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamDetail_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamDetail_Info_ParamValue")]
    protected Info _ParamValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamDetail_Info_ParamName")]
    protected Info _ParamName;

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
