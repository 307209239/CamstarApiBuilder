// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistEntry_Info
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
  public class ChecklistEntry_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_UserComments")]
    protected Info _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_LastCompletedByRole")]
    protected Info _LastCompletedByRole;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_ResponseSet")]
    protected Info _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_ActualResponses")]
    protected ChecklistActualResponse_Info _ActualResponses;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_CommentsEntry")]
    protected Info _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_ResponseLayout")]
    protected Info _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_ResponseEntryControl")]
    protected Info _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_LastCompletedOn")]
    protected Info _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_LastCompletedOnGMT")]
    protected Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_EntryRequired")]
    protected Info _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_LastCompletedBy")]
    protected Info _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_ChecklistText")]
    protected Info _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistEntry_Info_IsFrozen")]
    protected new Info _IsFrozen;

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

    public Info LastCompletedByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedByRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedByRole));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public ChecklistActualResponse_Info ActualResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualResponses), (object) value);
      }
      get
      {
        return (ChecklistActualResponse_Info) this.PropertyGet(nameof (ActualResponses));
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

    public Info LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Info LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedOnGMT));
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

    public Info LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedBy));
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

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
