// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetConditionChanges
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
  public class UITargetConditionChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_ConditionType")]
    protected Enumeration<ConditionTypeEnum, int> _ConditionType;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Parameter")]
    protected Primitive<string> _Parameter;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_ConditionValue")]
    protected Primitive<string> _ConditionValue;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UITargetConditionChanges && object.Equals((object) this._ListItemToChange, (object) ((UITargetConditionChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((UITargetConditionChanges) obj)._ObjectToChange) && object.Equals((object) this._ConditionType, (object) ((UITargetConditionChanges) obj)._ConditionType)) && (object.Equals((object) this._Parameter, (object) ((UITargetConditionChanges) obj)._Parameter) && object.Equals((object) this._ConditionValue, (object) ((UITargetConditionChanges) obj)._ConditionValue) && object.Equals((object) this._IsFrozen, (object) ((UITargetConditionChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<ConditionTypeEnum, int> ConditionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionType), (object) value);
      }
      get
      {
        return (Enumeration<ConditionTypeEnum, int>) this.PropertyGet(nameof (ConditionType));
      }
    }

    public Primitive<string> Parameter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Parameter));
      }
    }

    public Primitive<string> ConditionValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ConditionValue));
      }
    }

    public Primitive<bool> IsFrozen
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
  }
}
