// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTag_Environment
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
  public class FilterTag_Environment : UserCode_Environment
  {
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_FilterTags")]
    protected new Environment _FilterTags;
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, true, "NamedObjectRef", 1048764, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_InstanceID")]
    protected Environment _InstanceID;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    protected new Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_ChangeHistory")]
    protected new ChangeHistory_Environment _ChangeHistory;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778955, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Environment_Notes")]
    protected new Environment _Notes;

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
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

    public new Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
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

    public new Environment Description
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

    public new Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
