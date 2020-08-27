// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectToResolve_Environment
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
  public class ObjectToResolve_Environment : ObjectReferencesInfo_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_Environment_ObjectTypeName")]
    [Metadata("LongString", "", false, false, false, "String", 1050800, false, false, false, null)]
    protected new Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_Environment_ObjectType")]
    [Metadata("CDOType", "", false, false, false, "Integer", 1050797, false, false, false, null)]
    protected new Environment _ObjectType;
    [Metadata("LongString", "", false, false, false, "String", 1050774, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_Environment_ObjectName")]
    protected new Environment _ObjectName;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_Environment_Revision")]
    protected new Environment _Revision;

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
  }
}
