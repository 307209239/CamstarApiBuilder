// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ButtonLabelChanges_Environment
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
  public class ButtonLabelChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Environment_ListItemToChange")]
    [Metadata("Button Label", "ButtonLabelChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Environment_ObjectToChange")]
    [Metadata("Button Label", "ButtonLabel", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, false, false, "String", 1052772, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Environment_LabelName")]
    protected Environment _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Environment_LabelText")]
    [Metadata("Generic String", "", false, false, false, "String", 1049993, false, false, false, null)]
    protected Environment _LabelText;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Environment_IsFrozen")]
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

    public Environment LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelName));
      }
    }

    public Environment LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelText));
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
