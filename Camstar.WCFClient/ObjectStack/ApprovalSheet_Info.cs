// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheet_Info
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
  public class ApprovalSheet_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_GeneralInstructions")]
    protected Info _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_FromStage")]
    protected Info _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_ToStage")]
    protected Info _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_ApprovalEntries")]
    protected ApprovalSheetEntry_Info _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_ApprovalDecisionList")]
    protected Info _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_ApprovalRoutingInfo")]
    protected Info _ApprovalRoutingInfo;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_LastApprovalCycle")]
    protected Info _LastApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_DesignateOnApproval")]
    protected Info _DesignateOnApproval;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_ApprovalRequired")]
    protected Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_LastApprovalCycleGMT")]
    protected Info _LastApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Info_Description")]
    protected Info _Description;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
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

    public Info GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Info FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStage));
      }
    }

    public Info ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStage));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public ApprovalSheetEntry_Info ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalSheetEntry_Info) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public Info ApprovalDecisionList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisionList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalDecisionList));
      }
    }

    public Info ApprovalRoutingInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRoutingInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRoutingInfo));
      }
    }

    public Info LastApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycle), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastApprovalCycle));
      }
    }

    public Info DesignateOnApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (DesignateOnApproval), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DesignateOnApproval));
      }
    }

    public Info ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Info LastApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastApprovalCycleGMT));
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

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
