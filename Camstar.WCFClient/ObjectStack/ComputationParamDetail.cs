// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamDetail
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
  public class ComputationParamDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamDetail_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamDetail_ParamValue")]
    protected Primitive<string> _ParamValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamDetail_ParamName")]
    protected Primitive<string> _ParamName;

    public override bool Equals(object obj)
    {
      return obj is ComputationParamDetail && object.Equals((object) this._DataType, (object) ((ComputationParamDetail) obj)._DataType) && (object.Equals((object) this._ParamValue, (object) ((ComputationParamDetail) obj)._ParamValue) && object.Equals((object) this._ParamName, (object) ((ComputationParamDetail) obj)._ParamName)) && base.Equals(obj);
    }

    public Enumeration<DataTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public Primitive<string> ParamValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParamValue));
      }
    }

    public Primitive<string> ParamName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParamName));
      }
    }
  }
}
