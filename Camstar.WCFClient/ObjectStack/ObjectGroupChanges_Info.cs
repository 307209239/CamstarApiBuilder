// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectGroupChanges_Info
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
  public class ObjectGroupChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_DefaultForObjectTypes")]
    protected Info _DefaultForObjectTypes;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_NewEntry")]
    protected Info _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_ResolvedEntries")]
    protected Info _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_Entries")]
    protected Info _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_NewGroup")]
    protected Info _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_EntryType")]
    protected Info _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_Groups")]
    protected Info _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Info_Name")]
    protected new Info _Name;

    public Info DefaultForObjectTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultForObjectTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultForObjectTypes));
      }
    }

    public Info NewEntry
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

    public Info ResolvedEntries
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

    public Info Entries
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

    public Info NewGroup
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

    public Info EntryType
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

    public Info Groups
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
  }
}
