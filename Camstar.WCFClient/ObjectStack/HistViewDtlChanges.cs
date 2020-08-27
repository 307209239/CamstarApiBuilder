// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewDtlChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (HistViewHistMainlineDtlChanges))]
  [Serializable]
  public class HistViewDtlChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_UIFields")]
    protected Primitive<string>[] _UIFields;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is HistViewDtlChanges && this.CompareArrays((Array) this._UIFields, (Array) ((HistViewDtlChanges) obj)._UIFields) && (object.Equals((object) this._ObjectToChange, (object) ((HistViewDtlChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((HistViewDtlChanges) obj)._ListItemToChange)) && object.Equals((object) this._Name, (object) ((HistViewDtlChanges) obj)._Name) && base.Equals(obj);
    }

    public Primitive<string>[] UIFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIFields), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (UIFields));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
