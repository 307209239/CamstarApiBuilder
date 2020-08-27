// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UICustomActionChanges
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
  public class UICustomActionChanges : UIActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Parameters")]
    protected Primitive<string> _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_CustomMethodHandler")]
    protected Primitive<string> _CustomMethodHandler;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_IsReturn")]
    protected Primitive<bool> _IsReturn;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_ClearValues")]
    protected Primitive<bool> _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UICustomActionChanges && object.Equals((object) this._ObjectToChange, (object) ((UICustomActionChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((UICustomActionChanges) obj)._ListItemToChange) && object.Equals((object) this._Parameters, (object) ((UICustomActionChanges) obj)._Parameters)) && (object.Equals((object) this._CustomMethodHandler, (object) ((UICustomActionChanges) obj)._CustomMethodHandler) && object.Equals((object) this._IsReturn, (object) ((UICustomActionChanges) obj)._IsReturn) && (object.Equals((object) this._ClearValues, (object) ((UICustomActionChanges) obj)._ClearValues) && object.Equals((object) this._Name, (object) ((UICustomActionChanges) obj)._Name))) && base.Equals(obj);
    }

    public new NamedSubentityRef ObjectToChange
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

    public new NamedSubentityRef ListItemToChange
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

    public Primitive<string> Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Parameters));
      }
    }

    public Primitive<string> CustomMethodHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomMethodHandler), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomMethodHandler));
      }
    }

    public Primitive<bool> IsReturn
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReturn), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsReturn));
      }
    }

    public Primitive<bool> ClearValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearValues), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ClearValues));
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
