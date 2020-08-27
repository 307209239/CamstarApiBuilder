// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InspectionLevelMaint_Environment
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
  public class InspectionLevelMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevelChanges", false, false, false, "InspectionLevelChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelMaint_Environment_ObjectChanges")]
    protected InspectionLevelChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelMaint_Environment_ObjectListInquiry")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelMaint_Environment_ObjectToChange")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public InspectionLevelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (InspectionLevelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
