// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivityInvestigationChanges_Info))]
  [KnownType(typeof (ActivityDispositionChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ActivityChanges_Info : ProcessObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_ExecutionContextType")]
    protected new Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_CompleteWithinUOM")]
    protected new Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_Prerequisites")]
    protected new Info _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_onExecuteRules")]
    protected BusinessRuleDataChanges_Info _onExecuteRules;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_CompleteWithinQty")]
    protected new Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_AutoExecute")]
    protected Info _AutoExecute;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Info_Name")]
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

    public new Info Description
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

    public BusinessRuleDataChanges_Info onExecuteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onExecuteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onExecuteRules));
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

    public Info AutoExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoExecute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoExecute));
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
