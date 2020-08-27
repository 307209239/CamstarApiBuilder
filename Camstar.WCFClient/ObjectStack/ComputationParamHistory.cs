// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamHistory
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
  public class ComputationParamHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_ParamValue")]
    protected Primitive<string> _ParamValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_ParamName")]
    protected Primitive<string> _ParamName;

    public override bool Equals(object obj)
    {
      return obj is ComputationParamHistory && object.Equals((object) this._ExportImportKey, (object) ((ComputationParamHistory) obj)._ExportImportKey) && (object.Equals((object) this._DataType, (object) ((ComputationParamHistory) obj)._DataType) && object.Equals((object) this._ParamValue, (object) ((ComputationParamHistory) obj)._ParamValue)) && object.Equals((object) this._ParamName, (object) ((ComputationParamHistory) obj)._ParamName) && base.Equals(obj);
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
