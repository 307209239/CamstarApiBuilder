// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderListItemSettings
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
  public class MfgOrderListItemSettings : MaterialListItemSettings
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_TypeName")]
    protected new Primitive<string> _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_ParentName")]
    protected new Primitive<string> _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_QueryName")]
    protected new Primitive<string> _QueryName;

    public override bool Equals(object obj)
    {
      return obj is MfgOrderListItemSettings && object.Equals((object) this._TypeName, (object) ((MfgOrderListItemSettings) obj)._TypeName) && (object.Equals((object) this._ParentName, (object) ((MfgOrderListItemSettings) obj)._ParentName) && object.Equals((object) this._QueryName, (object) ((MfgOrderListItemSettings) obj)._QueryName)) && base.Equals(obj);
    }

    public new Primitive<string> TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TypeName));
      }
    }

    public new Primitive<string> ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentName));
      }
    }

    public new Primitive<string> QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QueryName));
      }
    }
  }
}
