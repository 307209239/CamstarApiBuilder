// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityInstance_Info
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
  public class SubentityInstance_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Info_ObjectFields")]
    protected ObjectField_Info _ObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Info_ObjectDisplayName")]
    protected Info _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Info_Instance")]
    protected BaseObject_Info _Instance;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;

    public ObjectField_Info ObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectFields), (object) value);
      }
      get
      {
        return (ObjectField_Info) this.PropertyGet(nameof (ObjectFields));
      }
    }

    public Info ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public BaseObject_Info Instance
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instance), (object) value);
      }
      get
      {
        return (BaseObject_Info) this.PropertyGet(nameof (Instance));
      }
    }

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
