// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISubmitAction
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
  public class UISubmitAction : UIAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UISubmitAction_IsReturn")]
    protected Primitive<bool> _IsReturn;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitAction_ClearValues")]
    protected Primitive<bool> _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UISubmitAction && object.Equals((object) this._IsReturn, (object) ((UISubmitAction) obj)._IsReturn) && (object.Equals((object) this._ClearValues, (object) ((UISubmitAction) obj)._ClearValues) && object.Equals((object) this._Name, (object) ((UISubmitAction) obj)._Name)) && base.Equals(obj);
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
