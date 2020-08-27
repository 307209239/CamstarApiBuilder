// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ButtonLabelChanges
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
  public class ButtonLabelChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_LabelText")]
    protected Primitive<string> _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabelChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ButtonLabelChanges && object.Equals((object) this._ListItemToChange, (object) ((ButtonLabelChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((ButtonLabelChanges) obj)._ObjectToChange) && object.Equals((object) this._LabelName, (object) ((ButtonLabelChanges) obj)._LabelName)) && (object.Equals((object) this._LabelText, (object) ((ButtonLabelChanges) obj)._LabelText) && object.Equals((object) this._IsFrozen, (object) ((ButtonLabelChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<string> LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelName));
      }
    }

    public Primitive<string> LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelText));
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
