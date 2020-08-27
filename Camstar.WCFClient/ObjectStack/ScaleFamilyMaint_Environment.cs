// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleFamilyMaint_Environment
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
  public class ScaleFamilyMaint_Environment : ResourceFamilyMaint_Environment
  {
    [Metadata("Scale Family is used to differentiate between types of Scales", "ScaleFamilyChanges", false, false, false, "ScaleFamilyChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_Environment_ObjectChanges")]
    protected ScaleFamilyChanges_Environment _ObjectChanges;
    [Metadata("Scale Family is used to differentiate between types of Scales", "ScaleFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Scale Family is used to differentiate between types of Scales", "ScaleFamily", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778972, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_Environment_UseUIPreference")]
    protected new Environment _UseUIPreference;

    public ScaleFamilyChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ScaleFamilyChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment UseUIPreference
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
