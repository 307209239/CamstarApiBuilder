// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetConditionChanges_Environment
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
  public class UITargetConditionChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("UI Target Condition", "UITargetConditionChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Defines conditions for UITarget CDO", "UITargetCondition", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Environment_ConditionType")]
    [Metadata("Enumeration for Condition Type:\r\n1 - Equal\r\n2 - NotEqual\r\n3 - Contains", "ConditionTypeEnum", false, false, false, "Integer", 1052737, false, false, true, null)]
    protected Environment _ConditionType;
    [Metadata("Generic String", "", false, false, false, "String", 1052749, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Environment_Parameter")]
    protected Environment _Parameter;
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Environment_ConditionValue")]
    [Metadata("Generic String", "", false, false, false, "String", 1052748, false, false, false, null)]
    protected Environment _ConditionValue;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UITargetConditionChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment ConditionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ConditionType));
      }
    }

    public Environment Parameter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parameter));
      }
    }

    public Environment ConditionValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ConditionValue));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
