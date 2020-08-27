// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDefChanges_Info
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
  public class ActionDefChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Info_SourcePages")]
    protected UISourcePageChanges_Info _SourcePages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Info_ActionRules")]
    protected Info _ActionRules;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Info_UIAction")]
    protected UIActionChanges_Info _UIAction;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Info_ActionType")]
    protected Info _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Info_Name")]
    protected new Info _Name;

    public UISourcePageChanges_Info SourcePages
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourcePages), (object) value);
      }
      get
      {
        return (UISourcePageChanges_Info) this.PropertyGet(nameof (SourcePages));
      }
    }

    public Info ActionRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRules), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionRules));
      }
    }

    public UIActionChanges_Info UIAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIAction), (object) value);
      }
      get
      {
        return (UIActionChanges_Info) this.PropertyGet(nameof (UIAction));
      }
    }

    public Info ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionType));
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
