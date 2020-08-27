// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InspectionLevelChanges_Environment
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
  public class InspectionLevelChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelChanges_Environment_LotSizeDetails")]
    [Metadata("A list of min./max. ranges used to define sample sizes.", "LotSizeDetailsChanges", false, true, false, "LotSizeDetailsChanges", 1053119, false, true, false, null)]
    protected LotSizeDetailsChanges_Environment _LotSizeDetails;
    [DataMember(EmitDefaultValue = false, Name = "InspectionLevelChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053120, false, false, false, null)]
    protected new Environment _Name;

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

    public LotSizeDetailsChanges_Environment LotSizeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSizeDetails), (object) value);
      }
      get
      {
        return (LotSizeDetailsChanges_Environment) this.PropertyGet(nameof (LotSizeDetails));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
