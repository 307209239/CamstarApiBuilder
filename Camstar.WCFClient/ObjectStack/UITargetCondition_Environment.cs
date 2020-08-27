// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetCondition_Environment
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
  public class UITargetCondition_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Enumeration for Condition Type:\r\n1 - Equal\r\n2 - NotEqual\r\n3 - Contains", "ConditionTypeEnum", false, false, false, "Integer", 1052737, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_Environment_ConditionType")]
    protected Environment _ConditionType;
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_Environment_Parameter")]
    [Metadata("Generic String", "", false, false, false, "String", 1052749, false, false, false, null)]
    protected Environment _Parameter;
    [Metadata("Generic String", "", false, false, false, "String", 1052748, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_Environment_ConditionValue")]
    protected Environment _ConditionValue;
    [DataMember(EmitDefaultValue = false, Name = "UITargetCondition_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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
