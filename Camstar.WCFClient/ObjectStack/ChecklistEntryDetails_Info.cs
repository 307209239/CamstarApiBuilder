﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntryDetails_Info
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
  public class ChecklistEntryDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_UserComments")]
    protected Info _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_ResponseLayout")]
    protected Info _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_ChecklistEntry")]
    protected Info _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_ResponseSet")]
    protected Info _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_ResponseEntryControl")]
    protected Info _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_CommentsEntry")]
    protected Info _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_EntryRequired")]
    protected Info _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_ChecklistText")]
    protected Info _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntryDetails_Info_Name")]
    protected Info _Name;

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info UserComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserComments));
      }
    }

    public Info ResponseLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseLayout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseLayout));
      }
    }

    public Info ChecklistEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistEntry));
      }
    }

    public Info ResponseSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseSet));
      }
    }

    public Info ResponseEntryControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseEntryControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseEntryControl));
      }
    }

    public Info CommentsEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentsEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CommentsEntry));
      }
    }

    public Info EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryRequired));
      }
    }

    public Info ChecklistText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistText));
      }
    }

    public Info Name
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
