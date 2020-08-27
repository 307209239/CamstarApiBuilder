// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleSizeDetailsChanges
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
  public class SampleSizeDetailsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_SampleSizeCode")]
    protected Primitive<string> _SampleSizeCode;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Accepts")]
    protected Primitive<int> _Accepts;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_SampleSize")]
    protected Primitive<string> _SampleSize;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Rejects")]
    protected Primitive<int> _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is SampleSizeDetailsChanges && object.Equals((object) this._ListItemToChange, (object) ((SampleSizeDetailsChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((SampleSizeDetailsChanges) obj)._ObjectToChange) && object.Equals((object) this._SampleSizeCode, (object) ((SampleSizeDetailsChanges) obj)._SampleSizeCode)) && (object.Equals((object) this._Accepts, (object) ((SampleSizeDetailsChanges) obj)._Accepts) && object.Equals((object) this._SampleSize, (object) ((SampleSizeDetailsChanges) obj)._SampleSize) && (object.Equals((object) this._Rejects, (object) ((SampleSizeDetailsChanges) obj)._Rejects) && object.Equals((object) this._IsFrozen, (object) ((SampleSizeDetailsChanges) obj)._IsFrozen))) && base.Equals(obj);
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

    public Primitive<int> Accepts
    {
      [param: In] set
      {
        this.PropertySet(nameof (Accepts), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Accepts));
      }
    }

    public Primitive<string> SampleSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSize), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleSize));
      }
    }

    public Primitive<int> Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Rejects));
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
