// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamSpecChanges
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
  public class ComputationParamSpecChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_DefaultValue")]
    protected Primitive<string> _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ComputationParamSpecChanges && object.Equals((object) this._DataType, (object) ((ComputationParamSpecChanges) obj)._DataType) && (object.Equals((object) this._DefaultValue, (object) ((ComputationParamSpecChanges) obj)._DefaultValue) && object.Equals((object) this._ObjectToChange, (object) ((ComputationParamSpecChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ListItemToChange, (object) ((ComputationParamSpecChanges) obj)._ListItemToChange) && object.Equals((object) this._Name, (object) ((ComputationParamSpecChanges) obj)._Name)) && base.Equals(obj);
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

    public Primitive<string> DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
