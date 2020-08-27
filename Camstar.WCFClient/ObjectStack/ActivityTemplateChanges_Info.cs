// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateChanges_Info
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
  public class ActivityTemplateChanges_Info : ProcessObjectTmpltChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_ExecutionContextType")]
    protected new Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_Details")]
    protected new ProcessObjectChanges_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_onExecuteRules")]
    protected BusinessRuleDataChanges_Info _onExecuteRules;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_AutoExecute")]
    protected Info _AutoExecute;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Info_Name")]
    protected new Info _Name;

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

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
