// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CarrierFamilyMaint_Environment
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
  public class CarrierFamilyMaint_Environment : ResourceFamilyMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_Environment_ObjectChanges")]
    [Metadata("Carrier Family is used to differentiate between types of Carriers such as 100 L Drum, Glass Tray, Metallic Tray, etc.", "CarrierFamilyChanges", false, false, false, "CarrierFamilyChanges", 1048873, true, false, false, null)]
    protected CarrierFamilyChanges_Environment _ObjectChanges;
    [Metadata("Carrier Family is used to differentiate between types of Carriers such as 100 L Drum, Glass Tray, Metallic Tray, etc.", "CarrierFamily", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Carrier Family is used to differentiate between types of Carriers such as 100 L Drum, Glass Tray, Metallic Tray, etc.", "CarrierFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778972, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_Environment_UseUIPreference")]
    protected new Environment _UseUIPreference;

    public CarrierFamilyChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (CarrierFamilyChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
