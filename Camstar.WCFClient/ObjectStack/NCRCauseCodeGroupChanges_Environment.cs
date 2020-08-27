// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCauseCodeGroupChanges_Environment
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
  public class NCRCauseCodeGroupChanges_Environment : UserCodeGroupChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_NewEntry")]
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, false, "NamedObjectRef", 1049324, false, false, true, null)]
    protected new Environment _NewEntry;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, false, "NamedObjectRef", 1048631, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_Entries")]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_ResolvedEntries")]
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1048760, false, true, true, null)]
    protected new Environment _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_NewGroup")]
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, false, "NamedObjectRef", 1049325, false, false, true, null)]
    protected new Environment _NewGroup;
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_Groups")]
    protected new Environment _Groups;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_ObjectToChange")]
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050409, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "NCRCauseCode")]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupChanges_Environment_EntryType")]
    protected new Environment _EntryType;

    public new Environment NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewEntry));
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

    public new Environment ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new Environment NewGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewGroup));
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
