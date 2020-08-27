// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PhaseDispositionChanges_Info))]
  [Serializable]
  public class PhaseChanges_Info : ProcessObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_ExecutionContextType")]
    protected new Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_Details")]
    protected new ProcessObjectChanges_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_CompleteWithinUOM")]
    protected new Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_onStartRules")]
    protected BusinessRuleDataChanges_Info _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_Prerequisites")]
    protected new Info _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_onCompleteRules")]
    protected BusinessRuleDataChanges_Info _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_ApprovalSheets")]
    protected ApprovalSheetChanges_Info _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_CompleteWithinQty")]
    protected new Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Info_Name")]
    protected new Info _Name;

    public new Info ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public new ProcessObjectChanges_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Info) this.PropertyGet(nameof (Details));
      }
    }

    public new Info CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public BusinessRuleDataChanges_Info onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new Info Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public BusinessRuleDataChanges_Info onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public ApprovalSheetChanges_Info ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheetChanges_Info) this.PropertyGet(nameof (ApprovalSheets));
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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinQty));
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
