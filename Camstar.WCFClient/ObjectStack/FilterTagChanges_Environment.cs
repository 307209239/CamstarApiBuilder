// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTagChanges_Environment
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
  public class FilterTagChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Environment_ObjectToChange")]
    [Metadata("Filter Tag CDO", "FilterTag", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, true, "NamedObjectRef", 1048764, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Environment_InstanceID")]
    protected Environment _InstanceID;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16778955, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Environment_Name")]
    protected new Environment _Name;

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

    public Environment InstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceID));
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
