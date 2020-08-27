// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceTypeChanges_Environment
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
  public class ResourceTypeChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Environment_UIPreference")]
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", false, false, false, "NamedObjectRef", 1051577, false, false, true, null)]
    protected Environment _UIPreference;
    [Metadata("Resource Type, a Resource categorization.  Resources with the same Resource Type may share the same Resources Status Model.", "ResourceType", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines a Resource Status Model which includes:\r\n1. Available initialization Resource Status Codes\r\n2. A Mapping of available \"From Status\" and \"To Statuses\"", "ResourceStatusModel", false, false, false, "NamedObjectRef", 1052849, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Environment_ResourceStatusModel")]
    protected Environment _ResourceStatusModel;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052922, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIPreference));
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

    public Environment ResourceStatusModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusModel));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
