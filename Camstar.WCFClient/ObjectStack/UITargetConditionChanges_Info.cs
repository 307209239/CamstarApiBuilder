// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetConditionChanges_Info
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
  public class UITargetConditionChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Info_ConditionType")]
    protected Info _ConditionType;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Info_Parameter")]
    protected Info _Parameter;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Info_ConditionValue")]
    protected Info _ConditionValue;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info ConditionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ConditionType));
      }
    }

    public Info Parameter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parameter));
      }
    }

    public Info ConditionValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ConditionValue));
      }
    }

    public Info IsFrozen
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
  }
}
