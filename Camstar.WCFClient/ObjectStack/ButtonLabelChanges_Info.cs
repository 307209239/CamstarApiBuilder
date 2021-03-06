﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ButtonLabelChanges_Info
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
  public class ButtonLabelChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Info_LabelName")]
    protected Info _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Info_LabelText")]
    protected Info _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_Info_IsFrozen")]
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

    public Info LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelName));
      }
    }

    public Info LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelText));
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
