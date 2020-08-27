// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceFamilyChanges_Environment
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
  public class ResourceFamilyChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", false, false, false, "NamedObjectRef", 1051577, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyChanges_Environment_UIPreference")]
    protected Environment _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyChanges_Environment_ObjectToChange")]
    [Metadata("Resource Family is used to differentiate between types of Resources such as Testers and Handlers.\r\n", "ResourceFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052139, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyChanges_Environment_Name")]
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
