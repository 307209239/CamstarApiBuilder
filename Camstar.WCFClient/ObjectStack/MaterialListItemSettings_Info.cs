// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItemSettings_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ProductListItemSettings_Info))]
  [KnownType(typeof (ERPBomListItemSettings_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MfgOrderListItemSettings_Info))]
  [Serializable]
  public class MaterialListItemSettings_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Info_QueryName")]
    protected Info _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Info_ParentName")]
    protected Info _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Info_TypeName")]
    protected Info _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Info_PhantomQueryName")]
    protected Info _PhantomQueryName;

    public Info QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryName));
      }
    }

    public Info ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentName));
      }
    }

    public Info TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TypeName));
      }
    }

    public Info PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhantomQueryName));
      }
    }
  }
}
