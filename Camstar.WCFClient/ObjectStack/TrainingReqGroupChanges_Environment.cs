// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingReqGroupChanges_Environment
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
  public class TrainingReqGroupChanges_Environment : RevisionedObjectGroupChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Environment_Entries")]
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, false, false, "RevisionedObjectRef", 1048631, false, true, true, null)]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Environment_ObjectToChange")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, false, true, "RevisionedObjectRef", 1048760, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Environment_ResolvedEntries")]
    protected new Environment _ResolvedEntries;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Environment_Groups")]
    protected new Environment _Groups;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "TrainingRequirement")]
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Environment_EntryType")]
    protected new Environment _EntryType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050476, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Environment_Name")]
    protected new Environment _Name;

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
