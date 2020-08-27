// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HorizontalShiftOptionsChanges
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
  public class HorizontalShiftOptionsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_HorizontalShiftDirection")]
    protected Enumeration<UIHorizontalShiftTypeEnum, int> _HorizontalShiftDirection;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_HorizontalShiftValue")]
    protected Primitive<int> _HorizontalShiftValue;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is HorizontalShiftOptionsChanges && object.Equals((object) this._ObjectToChange, (object) ((HorizontalShiftOptionsChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((HorizontalShiftOptionsChanges) obj)._ListItemToChange) && object.Equals((object) this._HorizontalShiftDirection, (object) ((HorizontalShiftOptionsChanges) obj)._HorizontalShiftDirection)) && (object.Equals((object) this._HorizontalShiftValue, (object) ((HorizontalShiftOptionsChanges) obj)._HorizontalShiftValue) && object.Equals((object) this._IsFrozen, (object) ((HorizontalShiftOptionsChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public Enumeration<UIHorizontalShiftTypeEnum, int> HorizontalShiftDirection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftDirection), (object) value);
      }
      get
      {
        return (Enumeration<UIHorizontalShiftTypeEnum, int>) this.PropertyGet(nameof (HorizontalShiftDirection));
      }
    }

    public Primitive<int> HorizontalShiftValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (HorizontalShiftValue));
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
