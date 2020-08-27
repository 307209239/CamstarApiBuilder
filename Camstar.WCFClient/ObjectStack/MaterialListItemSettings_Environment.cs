// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItemSettings_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ProductListItemSettings_Environment))]
  [KnownType(typeof (MfgOrderListItemSettings_Environment))]
  [KnownType(typeof (ERPBomListItemSettings_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaterialListItemSettings_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Environment_QueryName")]
    [Metadata("Generic String", "", false, false, true, "String", 1050871, false, false, false, null)]
    protected Environment _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Environment_ParentName")]
    [Metadata("Generic String", "", false, false, true, "String", 16779249, false, false, false, null)]
    protected Environment _ParentName;
    [Metadata("Generic String", "", false, false, true, "String", 16779177, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Environment_TypeName")]
    protected Environment _TypeName;
    [Metadata("Generic String", "", false, false, true, "String", 16779176, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemSettings_Environment_PhantomQueryName")]
    protected Environment _PhantomQueryName;

    public Environment QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryName));
      }
    }

    public Environment ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentName));
      }
    }

    public Environment TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeName));
      }
    }

    public Environment PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhantomQueryName));
      }
    }
  }
}
