// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPBomListItemSettings
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
  public class ERPBomListItemSettings : MaterialListItemSettings
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPBomListItemSettings_ParentName")]
    protected new Primitive<string> _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "ERPBomListItemSettings_PhantomQueryName")]
    protected new Primitive<string> _PhantomQueryName;
    [DataMember(EmitDefaultValue = false, Name = "ERPBomListItemSettings_TypeName")]
    protected new Primitive<string> _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "ERPBomListItemSettings_QueryName")]
    protected new Primitive<string> _QueryName;

    public override bool Equals(object obj)
    {
      return obj is ERPBomListItemSettings && object.Equals((object) this._ParentName, (object) ((ERPBomListItemSettings) obj)._ParentName) && (object.Equals((object) this._PhantomQueryName, (object) ((ERPBomListItemSettings) obj)._PhantomQueryName) && object.Equals((object) this._TypeName, (object) ((ERPBomListItemSettings) obj)._TypeName)) && object.Equals((object) this._QueryName, (object) ((ERPBomListItemSettings) obj)._QueryName) && base.Equals(obj);
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

    public new Primitive<string> PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PhantomQueryName));
      }
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
