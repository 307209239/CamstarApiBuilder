// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusModelMaint_Environment
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
  public class ResourceStatusModelMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelMaint_Environment_ObjectListInquiry")]
    [Metadata("Defines a Resource Status Model which includes:\r\n1. Available initialization Resource Status Codes\r\n2. A Mapping of available \"From Status\" and \"To Statuses\"", "ResourceStatusModel", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Defines a Resource Status Model which includes:\r\n1. Available initialization Resource Status Codes\r\n2. A Mapping of available \"From Status\" and \"To Statuses\"", "ResourceStatusModel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelMaint_Environment_ObjectChanges")]
    [Metadata("Defines a Resource Status Model which includes:\r\n1. Available initialization Resource Status Codes\r\n2. A Mapping of available \"From Status\" and \"To Statuses\"", "ResourceStatusModelChanges", false, false, false, "ResourceStatusModelChanges", 1048873, true, false, false, null)]
    protected ResourceStatusModelChanges_Environment _ObjectChanges;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ResourceStatusModelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ResourceStatusModelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
