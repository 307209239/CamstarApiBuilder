// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleGroupChanges_Environment
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
  public class ScaleGroupChanges_Environment : ResourceGroupChanges_Environment
  {
    [Metadata("A Named Object Group that represents a group of Scales", "ScaleGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Environment_Entries")]
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, false, "NamedObjectRef", 1048631, false, true, true, null)]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Environment_Groups")]
    [Metadata("A Named Object Group that represents a group of Scales", "ScaleGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    protected new Environment _Groups;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051920, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "Scale")]
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Environment_EntryType")]
    protected new Environment _EntryType;

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

    public new Environment Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Entries));
      }
    }

    public new Environment Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Groups));
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

    public new Environment EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EntryType));
      }
    }
  }
}
