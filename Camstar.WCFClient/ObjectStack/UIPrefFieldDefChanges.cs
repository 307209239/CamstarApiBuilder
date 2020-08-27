// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPrefFieldDefChanges
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
  public class UIPrefFieldDefChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_FieldSeq")]
    protected Primitive<int> _FieldSeq;

    public override bool Equals(object obj)
    {
      return obj is UIPrefFieldDefChanges && object.Equals((object) this._ObjectToChange, (object) ((UIPrefFieldDefChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((UIPrefFieldDefChanges) obj)._ListItemToChange) && object.Equals((object) this._Name, (object) ((UIPrefFieldDefChanges) obj)._Name)) && object.Equals((object) this._FieldSeq, (object) ((UIPrefFieldDefChanges) obj)._FieldSeq) && base.Equals(obj);
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

    public Primitive<int> FieldSeq
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSeq), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FieldSeq));
      }
    }
  }
}
