// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectReferencesInfo_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ObjectToResolve_Environment))]
  [Serializable]
  public class ObjectReferencesInfo_Environment : ObjectAlternateKey_Environment
  {
    [Metadata("Label Value.", "", false, false, false, "String", 1050776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_ObjectTypeValue")]
    protected Environment _ObjectTypeValue;
    [Metadata("CDOType", "", false, false, true, "Integer", 1050797, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_ObjectType")]
    protected new Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_ObjectTypeName")]
    [Metadata("LongString", "", false, false, true, "String", 1050800, false, false, false, null)]
    protected new Environment _ObjectTypeName;
    [Metadata("LongString", "", false, false, true, "String", 1050774, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_ObjectName")]
    protected new Environment _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_ObjectFields")]
    [Metadata("An object representing an on object reference field in an object definition metadata.", "ObjectField", false, false, true, "ObjectField", 1050846, false, true, false, null)]
    protected ObjectField_Environment _ObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_LastEditDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053098, false, false, false, null)]
    protected Environment _LastEditDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_LastEditDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053097, false, false, false, null)]
    protected Environment _LastEditDate;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObject", 1053199, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_ObjectInstance")]
    protected BaseObject_Environment _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_Revision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1048710, false, false, false, null)]
    protected new Environment _Revision;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1053096, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_LastEditBy")]
    protected Environment _LastEditBy;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Environment_Description")]
    protected Environment _Description;

    public Environment ObjectTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeValue));
      }
    }

    public new Environment ObjectType
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

    public new Environment ObjectTypeName
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

    public new Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }

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

    public Environment LastEditDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEditDateGMT));
      }
    }

    public Environment LastEditDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEditDate));
      }
    }

    public BaseObject_Environment ObjectInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstance), (object) value);
      }
      get
      {
        return (BaseObject_Environment) this.PropertyGet(nameof (ObjectInstance));
      }
    }

    public new Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public Environment LastEditBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEditBy));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
