// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRResolutionCodeGroupChanges_Info
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
  public class NCRResolutionCodeGroupChanges_Info : UserCodeGroupChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_Entries")]
    protected new Info _Entries;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_NewEntry")]
    protected new Info _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_NewGroup")]
    protected new Info _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_Groups")]
    protected new Info _Groups;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_ResolvedEntries")]
    protected new Info _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupChanges_Info_EntryType")]
    protected new Info _EntryType;

    public new Info Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Entries));
      }
    }

    public new Info NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewEntry));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info NewGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewGroup));
      }
    }

    public new Info Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Groups));
      }
    }

    public new Info ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryType));
      }
    }
  }
}
