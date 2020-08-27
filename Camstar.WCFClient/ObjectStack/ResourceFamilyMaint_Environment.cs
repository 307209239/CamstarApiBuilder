// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceFamilyMaint_Environment
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
  public class ResourceFamilyMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_Environment_ObjectListInquiry")]
    [Metadata("Resource Family is used to differentiate between types of Resources such as Testers and Handlers.\r\n", "ResourceFamily", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Resource Family is used to differentiate between types of Resources such as Testers and Handlers.\r\n", "ResourceFamilyChanges", false, false, false, "ResourceFamilyChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_Environment_ObjectChanges")]
    protected ResourceFamilyChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_Environment_ObjectToChange")]
    [Metadata("Resource Family is used to differentiate between types of Resources such as Testers and Handlers.\r\n", "ResourceFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_Environment_UseUIPreference")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778972, false, false, false, "1")]
    protected Environment _UseUIPreference;

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

    public ResourceFamilyChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ResourceFamilyChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public Environment UseUIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseUIPreference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseUIPreference));
      }
    }
  }
}
