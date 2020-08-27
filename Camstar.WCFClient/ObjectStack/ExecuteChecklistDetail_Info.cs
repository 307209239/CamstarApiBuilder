// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistDetail_Info
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
  public class ExecuteChecklistDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_UserComments")]
    protected Info _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_UserResponses")]
    protected ExecuteChklstResponseDtl_Info _UserResponses;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_ResponseSet")]
    protected Info _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_ChecklistEntry")]
    protected Info _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_ResponseEntryControl")]
    protected Info _ResponseEntryControl;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_CommentsEntry")]
    protected Info _CommentsEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_ResponseLayout")]
    protected Info _ResponseLayout;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_EntryRequired")]
    protected Info _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_LastCompletedOnGMT")]
    protected Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_LastCompletedBy")]
    protected Info _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_LastCompletedByRole")]
    protected Info _LastCompletedByRole;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistDetail_Info_ChecklistText")]
    protected Info _ChecklistText;

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

    public ExecuteChklstResponseDtl_Info UserResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserResponses), (object) value);
      }
      get
      {
        return (ExecuteChklstResponseDtl_Info) this.PropertyGet(nameof (UserResponses));
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
  }
}
