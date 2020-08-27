// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LotSizeDetailsChanges
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
  public class LotSizeDetailsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_MaxLotQty")]
    protected Primitive<int> _MaxLotQty;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_MinLotQty")]
    protected Primitive<int> _MinLotQty;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_SampleSizeCode")]
    protected Primitive<string> _SampleSizeCode;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is LotSizeDetailsChanges && object.Equals((object) this._ListItemToChange, (object) ((LotSizeDetailsChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((LotSizeDetailsChanges) obj)._ObjectToChange) && object.Equals((object) this._MaxLotQty, (object) ((LotSizeDetailsChanges) obj)._MaxLotQty)) && (object.Equals((object) this._MinLotQty, (object) ((LotSizeDetailsChanges) obj)._MinLotQty) && object.Equals((object) this._SampleSizeCode, (object) ((LotSizeDetailsChanges) obj)._SampleSizeCode) && object.Equals((object) this._IsFrozen, (object) ((LotSizeDetailsChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<int> MaxLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxLotQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaxLotQty));
      }
    }

    public Primitive<int> MinLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinLotQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MinLotQty));
      }
    }

    public Primitive<string> SampleSizeCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleSizeCode));
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
