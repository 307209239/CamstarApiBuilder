// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityInstance
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
  public class SubentityInstance : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_ObjectFields")]
    protected ObjectField[] _ObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_ObjectDisplayName")]
    protected Primitive<string> _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Instance")]
    protected BaseObject _Instance;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;

    public override bool Equals(object obj)
    {
      return obj is SubentityInstance && this.CompareArrays((Array) this._ObjectFields, (Array) ((SubentityInstance) obj)._ObjectFields) && (object.Equals((object) this._ObjectDisplayName, (object) ((SubentityInstance) obj)._ObjectDisplayName) && object.Equals((object) this._ObjectType, (object) ((SubentityInstance) obj)._ObjectType)) && (object.Equals((object) this._Instance, (object) ((SubentityInstance) obj)._Instance) && object.Equals((object) this._ObjectTypeName, (object) ((SubentityInstance) obj)._ObjectTypeName)) && base.Equals(obj);
    }

    public ObjectField[] ObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectFields), (object) value);
      }
      get
      {
        return (ObjectField[]) this.PropertyGet(nameof (ObjectFields));
      }
    }

    public Primitive<string> ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public Primitive<int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public BaseObject Instance
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instance), (object) value);
      }
      get
      {
        return (BaseObject) this.PropertyGet(nameof (Instance));
      }
    }

    public Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
