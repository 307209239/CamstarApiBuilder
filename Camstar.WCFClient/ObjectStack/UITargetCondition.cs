// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetCondition
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
  public class UITargetCondition : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_ConditionType")]
    protected Enumeration<ConditionTypeEnum, int> _ConditionType;
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_Parameter")]
    protected Primitive<string> _Parameter;
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_ConditionValue")]
    protected Primitive<string> _ConditionValue;
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UITargetCondition && object.Equals((object) this._ExportImportKey, (object) ((UITargetCondition) obj)._ExportImportKey) && (object.Equals((object) this._ConditionType, (object) ((UITargetCondition) obj)._ConditionType) && object.Equals((object) this._Parameter, (object) ((UITargetCondition) obj)._Parameter)) && (object.Equals((object) this._ConditionValue, (object) ((UITargetCondition) obj)._ConditionValue) && object.Equals((object) this._IsFrozen, (object) ((UITargetCondition) obj)._IsFrozen)) && base.Equals(obj);
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
