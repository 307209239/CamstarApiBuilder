// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheet
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
  public class ApprovalSheet : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_FromStage")]
    protected Enumeration<StageEnum, int> _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_ToStage")]
    protected Enumeration<StageEnum, int> _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Status")]
    protected Enumeration<ApprovalStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_ApprovalEntries")]
    protected ApprovalSheetEntry[] _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_ApprovalDecisionList")]
    protected NamedObjectRef _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_ApprovalRoutingInfo")]
    protected SubentityRef _ApprovalRoutingInfo;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_LastApprovalCycle")]
    protected Primitive<DateTime> _LastApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_DesignateOnApproval")]
    protected Primitive<bool> _DesignateOnApproval;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_LastApprovalCycleGMT")]
    protected Primitive<DateTime> _LastApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheet && object.Equals((object) this._Comments, (object) ((ApprovalSheet) obj)._Comments) && (object.Equals((object) this._ExportImportKey, (object) ((ApprovalSheet) obj)._ExportImportKey) && object.Equals((object) this._GeneralInstructions, (object) ((ApprovalSheet) obj)._GeneralInstructions)) && (object.Equals((object) this._FromStage, (object) ((ApprovalSheet) obj)._FromStage) && object.Equals((object) this._ToStage, (object) ((ApprovalSheet) obj)._ToStage) && (object.Equals((object) this._Status, (object) ((ApprovalSheet) obj)._Status) && this.CompareArrays((Array) this._ApprovalEntries, (Array) ((ApprovalSheet) obj)._ApprovalEntries))) && (object.Equals((object) this._ApprovalDecisionList, (object) ((ApprovalSheet) obj)._ApprovalDecisionList) && object.Equals((object) this._ApprovalRoutingInfo, (object) ((ApprovalSheet) obj)._ApprovalRoutingInfo) && (object.Equals((object) this._LastApprovalCycle, (object) ((ApprovalSheet) obj)._LastApprovalCycle) && object.Equals((object) this._DesignateOnApproval, (object) ((ApprovalSheet) obj)._DesignateOnApproval)) && (object.Equals((object) this._ApprovalRequired, (object) ((ApprovalSheet) obj)._ApprovalRequired) && object.Equals((object) this._LastApprovalCycleGMT, (object) ((ApprovalSheet) obj)._LastApprovalCycleGMT) && (object.Equals((object) this._IsFrozen, (object) ((ApprovalSheet) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((ApprovalSheet) obj)._Name)))) && object.Equals((object) this._Description, (object) ((ApprovalSheet) obj)._Description) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Enumeration<StageEnum, int> FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (FromStage));
      }
    }

    public Enumeration<StageEnum, int> ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (ToStage));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public ApprovalSheetEntry[] ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalSheetEntry[]) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public NamedObjectRef ApprovalDecisionList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisionList), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalDecisionList));
      }
    }

    public SubentityRef ApprovalRoutingInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRoutingInfo), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalRoutingInfo));
      }
    }

    public Primitive<DateTime> LastApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycle), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastApprovalCycle));
      }
    }

    public Primitive<bool> DesignateOnApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (DesignateOnApproval), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DesignateOnApproval));
      }
    }

    public Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Primitive<DateTime> LastApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastApprovalCycleGMT));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
