// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UICustomAction
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
  public class UICustomAction : UIAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_CustomMethodHandler")]
    protected Primitive<string> _CustomMethodHandler;
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Parameters")]
    protected Primitive<string> _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_ClearValues")]
    protected Primitive<bool> _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_IsReturn")]
    protected Primitive<bool> _IsReturn;
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UICustomAction && object.Equals((object) this._CustomMethodHandler, (object) ((UICustomAction) obj)._CustomMethodHandler) && (object.Equals((object) this._Parameters, (object) ((UICustomAction) obj)._Parameters) && object.Equals((object) this._ClearValues, (object) ((UICustomAction) obj)._ClearValues)) && (object.Equals((object) this._IsReturn, (object) ((UICustomAction) obj)._IsReturn) && object.Equals((object) this._Name, (object) ((UICustomAction) obj)._Name)) && base.Equals(obj);
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
