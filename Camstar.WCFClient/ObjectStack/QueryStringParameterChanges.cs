// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QueryStringParameterChanges
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
  public class QueryStringParameterChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_SourceMember")]
    protected Primitive<string> _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is QueryStringParameterChanges && object.Equals((object) this._ObjectToChange, (object) ((QueryStringParameterChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((QueryStringParameterChanges) obj)._ListItemToChange) && object.Equals((object) this._Name, (object) ((QueryStringParameterChanges) obj)._Name)) && (object.Equals((object) this._SourceMember, (object) ((QueryStringParameterChanges) obj)._SourceMember) && object.Equals((object) this._IsFrozen, (object) ((QueryStringParameterChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<string> Name
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

    public Primitive<string> SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceMember));
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
