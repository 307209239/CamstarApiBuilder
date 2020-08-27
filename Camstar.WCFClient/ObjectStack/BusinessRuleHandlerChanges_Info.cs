// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleHandlerChanges_Info
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
  public class BusinessRuleHandlerChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Info_HandlerData")]
    protected BusinessRuleHandlerDataChanges_Info _HandlerData;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Info_ValidationStatus")]
    protected Info _ValidationStatus;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Info_ValidateOnSave")]
    protected Info _ValidateOnSave;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Info_Name")]
    protected new Info _Name;

    public BusinessRuleHandlerDataChanges_Info HandlerData
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerData), (object) value);
      }
      get
      {
        return (BusinessRuleHandlerDataChanges_Info) this.PropertyGet(nameof (HandlerData));
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

    public Info ValidationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidationStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidationStatus));
      }
    }

    public Info ValidateOnSave
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateOnSave), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidateOnSave));
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
