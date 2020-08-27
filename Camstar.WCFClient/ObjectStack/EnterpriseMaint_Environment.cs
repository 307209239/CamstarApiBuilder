// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EnterpriseMaint_Environment
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
  public class EnterpriseMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for Enterprise.", "EnterpriseChanges", false, false, false, "EnterpriseChanges", 1048873, true, false, false, null)]
    protected EnterpriseChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseMaint_Environment_ObjectListInquiry")]
    [Metadata("The Enterprise refers to the highest level in the factory definition. The Enterprise can represent the company itself, or a large division of the company. An Enterprise can contain one or more factories.", "Enterprise", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("The Enterprise refers to the highest level in the factory definition. The Enterprise can represent the company itself, or a large division of the company. An Enterprise can contain one or more factories.", "Enterprise", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public EnterpriseChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EnterpriseChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
