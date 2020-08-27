// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleHandlerChanges
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
  public class BusinessRuleHandlerChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_HandlerData")]
    protected BusinessRuleHandlerDataChanges _HandlerData;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_ValidationStatus")]
    protected Enumeration<BizRuleHandlerStatusEnum, int> _ValidationStatus;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_ValidateOnSave")]
    protected Primitive<bool> _ValidateOnSave;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BusinessRuleHandlerChanges && object.Equals((object) this._HandlerData, (object) ((BusinessRuleHandlerChanges) obj)._HandlerData) && (object.Equals((object) this._ObjectToChange, (object) ((BusinessRuleHandlerChanges) obj)._ObjectToChange) && object.Equals((object) this._ValidationStatus, (object) ((BusinessRuleHandlerChanges) obj)._ValidationStatus)) && (object.Equals((object) this._ValidateOnSave, (object) ((BusinessRuleHandlerChanges) obj)._ValidateOnSave) && object.Equals((object) this._Name, (object) ((BusinessRuleHandlerChanges) obj)._Name)) && base.Equals(obj);
    }

    public BusinessRuleHandlerDataChanges HandlerData
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerData), (object) value);
      }
      get
      {
        return (BusinessRuleHandlerDataChanges) this.PropertyGet(nameof (HandlerData));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<BizRuleHandlerStatusEnum, int> ValidationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidationStatus), (object) value);
      }
      get
      {
        return (Enumeration<BizRuleHandlerStatusEnum, int>) this.PropertyGet(nameof (ValidationStatus));
      }
    }

    public Primitive<bool> ValidateOnSave
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateOnSave), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ValidateOnSave));
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
  }
}
