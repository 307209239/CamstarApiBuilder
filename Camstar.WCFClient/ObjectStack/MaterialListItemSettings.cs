// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItemSettings
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ProductListItemSettings))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ERPBomListItemSettings))]
  [KnownType(typeof (MfgOrderListItemSettings))]
  [Serializable]
  public class MaterialListItemSettings : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_QueryName")]
    protected Primitive<string> _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_ParentName")]
    protected Primitive<string> _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_TypeName")]
    protected Primitive<string> _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_PhantomQueryName")]
    protected Primitive<string> _PhantomQueryName;

    public override bool Equals(object obj)
    {
      return obj is MaterialListItemSettings && object.Equals((object) this._QueryName, (object) ((MaterialListItemSettings) obj)._QueryName) && (object.Equals((object) this._ParentName, (object) ((MaterialListItemSettings) obj)._ParentName) && object.Equals((object) this._TypeName, (object) ((MaterialListItemSettings) obj)._TypeName)) && object.Equals((object) this._PhantomQueryName, (object) ((MaterialListItemSettings) obj)._PhantomQueryName) && base.Equals(obj);
    }

    public Primitive<string> QueryName
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

    public Primitive<string> ParentName
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

    public Primitive<string> TypeName
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

    public Primitive<string> PhantomQueryName
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
  }
}
