// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLocationChanges
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
  public class UIFloatPageLocationChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Height")]
    protected Primitive<int> _Height;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Width")]
    protected Primitive<int> _Width;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIFloatPageLocationChanges && object.Equals((object) this._ListItemToChange, (object) ((UIFloatPageLocationChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((UIFloatPageLocationChanges) obj)._ObjectToChange) && object.Equals((object) this._Height, (object) ((UIFloatPageLocationChanges) obj)._Height)) && (object.Equals((object) this._Width, (object) ((UIFloatPageLocationChanges) obj)._Width) && object.Equals((object) this._IsFrozen, (object) ((UIFloatPageLocationChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<int> Height
    {
      [param: In] set
      {
        this.PropertySet(nameof (Height), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Height));
      }
    }

    public Primitive<int> Width
    {
      [param: In] set
      {
        this.PropertySet(nameof (Width), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Width));
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
