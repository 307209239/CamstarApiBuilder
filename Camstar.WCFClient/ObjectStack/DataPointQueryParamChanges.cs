// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointQueryParamChanges
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
  public class DataPointQueryParamChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Parent")]
    protected NamedSubentityRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_ParameterExpression")]
    protected Primitive<string> _ParameterExpression;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_ParameterName")]
    protected Primitive<string> _ParameterName;

    public override bool Equals(object obj)
    {
      return obj is DataPointQueryParamChanges && object.Equals((object) this._Parent, (object) ((DataPointQueryParamChanges) obj)._Parent) && (object.Equals((object) this._ParameterExpression, (object) ((DataPointQueryParamChanges) obj)._ParameterExpression) && object.Equals((object) this._ListItemToChange, (object) ((DataPointQueryParamChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((DataPointQueryParamChanges) obj)._ObjectToChange) && object.Equals((object) this._IsFrozen, (object) ((DataPointQueryParamChanges) obj)._IsFrozen) && object.Equals((object) this._ParameterName, (object) ((DataPointQueryParamChanges) obj)._ParameterName)) && base.Equals(obj);
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

    public Primitive<string> ParameterExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterExpression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParameterExpression));
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

    public Primitive<string> ParameterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParameterName));
      }
    }
  }
}
