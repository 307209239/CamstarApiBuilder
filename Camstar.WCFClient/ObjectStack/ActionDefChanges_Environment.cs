// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDefChanges_Environment
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
  public class ActionDefChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("UI Source Page", "UISourcePageChanges", false, false, false, "UISourcePageChanges", 1052841, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Environment_SourcePages")]
    protected UISourcePageChanges_Environment _SourcePages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Environment_ActionRules")]
    [Metadata("ActionRules is used to define expressions for Actions.", "ActionRule", false, false, false, "NamedObjectRef", 1052694, false, true, true, null)]
    protected Environment _ActionRules;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Environment_UIAction")]
    [Metadata("UIAction is used to save Portal Studio data related to an Action", "UIActionChanges", false, true, false, "UIActionChanges", 1052775, false, false, false, null)]
    protected UIActionChanges_Environment _UIAction;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Environment_ActionType")]
    [Metadata("Enumeration for the Action Types:\r\n1 = Container\r\n2 = QualityObject\r\n3 = ChangePackage", "ActionTypeEnum", false, false, false, "Integer", 1052690, false, false, true, "1")]
    protected Environment _ActionType;
    [Metadata("The Action CDO is based on an ActionRule and used to identify if this action could be performed against an object.", "ActionDef", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052687, false, false, false, null)]
    protected new Environment _Name;

    public UISourcePageChanges_Environment SourcePages
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourcePages), (object) value);
      }
      get
      {
        return (UISourcePageChanges_Environment) this.PropertyGet(nameof (SourcePages));
      }
    }

    public Environment ActionRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRules), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionRules));
      }
    }

    public UIActionChanges_Environment UIAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIAction), (object) value);
      }
      get
      {
        return (UIActionChanges_Environment) this.PropertyGet(nameof (UIAction));
      }
    }

    public Environment ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionType));
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
