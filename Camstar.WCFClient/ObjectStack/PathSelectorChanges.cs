// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathSelectorChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MovePathSelectorChanges))]
  [KnownType(typeof (ReworkPathSelectorChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class PathSelectorChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Expression")]
    protected Primitive<string> _Expression;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Parent")]
    protected NamedSubentityRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is PathSelectorChanges && object.Equals((object) this._ObjectToChange, (object) ((PathSelectorChanges) obj)._ObjectToChange) && (object.Equals((object) this._Expression, (object) ((PathSelectorChanges) obj)._Expression) && object.Equals((object) this._Parent, (object) ((PathSelectorChanges) obj)._Parent)) && (object.Equals((object) this._Path, (object) ((PathSelectorChanges) obj)._Path) && object.Equals((object) this._EffectiveFromDateGMT, (object) ((PathSelectorChanges) obj)._EffectiveFromDateGMT) && (object.Equals((object) this._EffectiveFromDate, (object) ((PathSelectorChanges) obj)._EffectiveFromDate) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((PathSelectorChanges) obj)._EffectiveThruDateGMT))) && (object.Equals((object) this._EffectiveThruDate, (object) ((PathSelectorChanges) obj)._EffectiveThruDate) && object.Equals((object) this._Notes, (object) ((PathSelectorChanges) obj)._Notes) && (object.Equals((object) this._Status, (object) ((PathSelectorChanges) obj)._Status) && object.Equals((object) this._IsFrozen, (object) ((PathSelectorChanges) obj)._IsFrozen)) && object.Equals((object) this._Description, (object) ((PathSelectorChanges) obj)._Description)) && base.Equals(obj);
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

    public Primitive<string> Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Expression));
      }
    }

    public NamedSubentityRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Parent));
      }
    }

    public NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
      }
    }

    public Primitive<DateTime> EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Primitive<DateTime> EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Primitive<DateTime> EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Primitive<DateTime> EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
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

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
