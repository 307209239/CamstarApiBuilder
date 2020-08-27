// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathSelector
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MovePathSelector))]
  [KnownType(typeof (ReworkPathSelector))]
  [Serializable]
  public class PathSelector : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_IsEnabled")]
    protected Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Expression")]
    protected Primitive<string> _Expression;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is PathSelector && object.Equals((object) this._Path, (object) ((PathSelector) obj)._Path) && (object.Equals((object) this._ExportImportKey, (object) ((PathSelector) obj)._ExportImportKey) && object.Equals((object) this._IsEnabled, (object) ((PathSelector) obj)._IsEnabled)) && (object.Equals((object) this._Expression, (object) ((PathSelector) obj)._Expression) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((PathSelector) obj)._EffectiveThruDateGMT) && (object.Equals((object) this._EffectiveFromDate, (object) ((PathSelector) obj)._EffectiveFromDate) && object.Equals((object) this._EffectiveFromDateGMT, (object) ((PathSelector) obj)._EffectiveFromDateGMT))) && (object.Equals((object) this._EffectiveThruDate, (object) ((PathSelector) obj)._EffectiveThruDate) && object.Equals((object) this._Notes, (object) ((PathSelector) obj)._Notes) && (object.Equals((object) this._Description, (object) ((PathSelector) obj)._Description) && object.Equals((object) this._Status, (object) ((PathSelector) obj)._Status)) && object.Equals((object) this._IsFrozen, (object) ((PathSelector) obj)._IsFrozen)) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<bool> IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsEnabled));
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
  }
}
