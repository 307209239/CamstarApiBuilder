// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityInstance_Environment
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
  public class SubentityInstance_Environment : ServiceData_Environment
  {
    [Metadata("An object representing an on object reference field in an object definition metadata.", "ObjectField", false, false, true, "ObjectField", 1050846, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Environment_ObjectFields")]
    protected ObjectField_Environment _ObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Environment_ObjectDisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1049729, false, false, false, null)]
    protected Environment _ObjectDisplayName;
    [Metadata("CDOType", "", false, false, true, "Integer", 1050797, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Environment_ObjectType")]
    protected Environment _ObjectType;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObject", 1053198, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Environment_Instance")]
    protected BaseObject_Environment _Instance;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1050800, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityInstance_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;

    public ObjectField_Environment ObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectFields), (object) value);
      }
      get
      {
        return (ObjectField_Environment) this.PropertyGet(nameof (ObjectFields));
      }
    }

    public Environment ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public BaseObject_Environment Instance
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instance), (object) value);
      }
      get
      {
        return (BaseObject_Environment) this.PropertyGet(nameof (Instance));
      }
    }

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
